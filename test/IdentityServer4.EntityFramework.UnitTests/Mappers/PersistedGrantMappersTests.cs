﻿using IdentityServer4.EntityFramework.Mappers;
using IdentityServer4.Models;
using Xunit;

namespace IdentityServer4.EntityFramework.UnitTests.Mappers
{
    public class PersistedGrantMappersTests
    {
        [Fact]
        public void PersistedGrantAutomapperConfigurationIsValid()
        {
            var model = new PersistedGrant();
            var mappedEntity = model.ToEntity();
            var mappedModel = mappedEntity.ToModel();
            
            Assert.NotNull(mappedModel);
            Assert.NotNull(mappedEntity);
            PersistedGrantMappers.Mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}