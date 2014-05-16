﻿using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using SFA.Apprenticeships.Common.Configuration;
using SFA.Apprenticeships.Services.Common.Wcf;
using SFA.Apprenticeships.Services.ReferenceData.Abstract;
using SFA.Apprenticeships.Services.ReferenceData.Models;
using SFA.Apprenticeships.Services.ReferenceData.Proxy;
using SFA.Apprenticeships.Services.ReferenceData.Service;

namespace SFA.Apprenticeships.Services.ReferenceData.IntegrationTests
{
    [TestFixture]
    public class ReferenceDataTests
    {
        private IReferenceDataService _service;

        [TestFixtureSetUp]
        public void Setup()
        {
            var configManager = new ConfigurationManager();
            var wcf = new WcfService<IReferenceData>();
            _service = new ReferenceDataService(configManager, wcf);
        }

        [TestCase]
        public void TheServiceEndpointShouldRespond()
        {
           var configManager = new ConfigurationManager();
            
            var result = default(GetApprenticeshipFrameworksResponse);

            var msgId = new Guid();
            var username = configManager.GetAppSetting(ReferenceDataService.ReferenceDataSystemIdKey);
            var password = configManager.GetAppSetting(ReferenceDataService.ReferenceDataPublicKey);

            var rq = new GetApprenticeshipFrameworksRequest(new Guid(username), msgId, password);
            var service = new WcfService<IReferenceData>();
            service.Use(client=> { result = client.GetApprenticeshipFrameworks(rq); });

            result.Should().NotBeNull();
        }

        [TestCase]
        public void GetApprenticeshipFrameworksShouldReturnList()
        {       
            var test = _service.GetApprenticeshipFrameworks();

            test.Should().NotBeNullOrEmpty();
            test.Count().Should().Be(216);
        }

        [TestCase]
        public void GetCountiesShouldReturnList()
        {
            var test = _service.GetCounties();

            test.Should().NotBeNullOrEmpty();
            test.Count().Should().Be(46);
        }

        [TestCase]
        public void GetErrorCodesShouldReturnList()
        {
            var test = _service.GetErrorCodes();

            test.Should().NotBeNullOrEmpty();
            test.Count().Should().Be(72);
        }

        [TestCase]
        public void GetLocalAuthoritiesShouldReturnList()
        {
            var test = _service.GetLocalAuthorities();

            test.Should().NotBeNullOrEmpty();
            test.Count().Should().Be(326);
        }

        [TestCase]
        public void GetRegionsShouldReturnList()
        {
            var test = _service.GetRegions();

            test.Should().NotBeNullOrEmpty();
            test.Count().Should().Be(10);
        }

        [TestCase(LegacyReferenceDataType.County)]
        [TestCase(LegacyReferenceDataType.ErrorCode)]
        [TestCase(LegacyReferenceDataType.Framework)]
        [TestCase(LegacyReferenceDataType.LocalAuthority)]
        [TestCase(LegacyReferenceDataType.Occupations)]
        [TestCase(LegacyReferenceDataType.Region)]
        public void GetReferenceDataShouldReturnCollection(LegacyReferenceDataType type)
        {
            var test = _service.GetReferenceData(type);

            test.Should().NotBeNullOrEmpty();
        }
    }
}
