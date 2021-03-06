﻿namespace SFA.Infrastructure.Console
{
    using System;
    using Apprenticeships.Application.Interfaces;

    public class ConsoleLogService : ILogService
    {
        public void Debug(string message, params object[] args)
        {
            Log("DEBUG", message, null, args);
        }

        public void Info(string message, params object[] args)
        {
            Log("INFO", message, null, args);
        }

        public void Warn(string message, Exception exception, params object[] args)
        {
            Log("WARN", message, null, args);
        }

        public void Warn(string message, params object[] args)
        {
            Log("WARN", message, null, args);
        }

        public void Warn(Exception exception, object data = null)
        {
            Log("WARN", data == null ? "" : data.ToString(), exception, new object[] { });
        }

        public void Error(string message, Exception exception, params object[] args)
        {
            Log("ERROR", message, exception, args);
        }

        public void Error(string message, params object[] args)
        {
            Log("ERROR", message, null, args);
        }

        public void Error(Exception exception, object data = null)
        {
            Log("ERROR", data == null ? "" : data.ToString(), exception, new object[] { });
        }

        private void Log(string level, string message, Exception exception, object[] args)
        {
            string formattedMessage = message;
            if (args.Length > 0)
            {
                try
                {
                    formattedMessage = string.Format(message, args);
                }
                catch (FormatException)
                {
                }
            }

            // $"{level:0,5}"
            Console.WriteLine(DateTime.Now.ToString("ss.ff ") + string.Format("{0,-6} ", level + ":") + formattedMessage);
            if (exception != null)
                Console.WriteLine(exception.ToString());
        }
    }
}
