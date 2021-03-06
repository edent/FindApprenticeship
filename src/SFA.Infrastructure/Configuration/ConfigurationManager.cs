﻿namespace SFA.Infrastructure.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using Interfaces;
    using CuttingEdge.Conditions;

    public class ConfigurationManager : IConfigurationManager
    {
        public const string ConfigurationFileAppSettingName = "ConfigurationPath";

        private Configuration Configuration { get; }

        public ConfigurationManager()
        {
            var configMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = ConfigurationFilePath
            };

            Configuration = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
        }

        public string TryGetAppSetting(string key)
        {
            Condition.Requires(key, "key").IsNotNullOrWhiteSpace();
            var result = Configuration.AppSettings.Settings[key];

            return result != null ? result.Value : null;
        }

        public string ConfigurationFilePath
        {
            get
            {
                var configFile = System.Configuration.ConfigurationManager.AppSettings[ConfigurationFileAppSettingName];

                if (!File.Exists(configFile))
                {
                    configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFile);
                }

                if (!File.Exists(configFile))
                {
                    throw new ConfigurationErrorsException($"Configuration file: {(object) configFile} does not exist");
                }

                return configFile;
            }
        }

        public string GetAppSetting(string key)
        {
            var setting = TryGetAppSetting(key);
            if (setting == null)
            {
                throw new KeyNotFoundException(
                    $"'{key}' was not found, or multiple values for the same key, in settings configuration file.");
            }

            return setting;
        }

        public T GetAppSetting<T>(string key)
        {
            var setting = GetAppSetting(key);
            return (T) Convert.ChangeType(setting, typeof (T));
        }

        public ConfigurationSection GetSection(string sectionName)
        {
            return Configuration.GetSection(sectionName);
        }
    }
}
