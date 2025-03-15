/*
 * v2 API
 *
 * OpenAPI spec for Solr's v2 API endpoints
 *
 * The version of the OpenAPI document: 9.8.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using SolrClient.Client;
using SolrClient.Api;
// uncomment below to import models
//using SolrClient.Model;

namespace SolrClient.Test.Api
{
    /// <summary>
    ///  Class for testing AliasPropertiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AliasPropertiesApiTests : IDisposable
    {
        private AliasPropertiesApi instance;

        public AliasPropertiesApiTests()
        {
            instance = new AliasPropertiesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AliasPropertiesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AliasPropertiesApi
            //Assert.IsType<AliasPropertiesApi>(instance);
        }

        /// <summary>
        /// Test CreateOrUpdateAliasProperty
        /// </summary>
        [Fact]
        public void CreateOrUpdateAliasPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aliasName = null;
            //string propName = null;
            //UpdateAliasPropertyRequestBodyModel updateAliasPropertyRequestBodyModel = null;
            //var response = instance.CreateOrUpdateAliasProperty(aliasName, propName, updateAliasPropertyRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test DeleteAliasProperty
        /// </summary>
        [Fact]
        public void DeleteAliasPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aliasName = null;
            //string propName = null;
            //var response = instance.DeleteAliasProperty(aliasName, propName);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test GetAliasProperty
        /// </summary>
        [Fact]
        public void GetAliasPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aliasName = null;
            //string propName = null;
            //var response = instance.GetAliasProperty(aliasName, propName);
            //Assert.IsType<GetAliasPropertyResponseModel>(response);
        }

        /// <summary>
        /// Test GetAllAliasProperties
        /// </summary>
        [Fact]
        public void GetAllAliasPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aliasName = null;
            //var response = instance.GetAllAliasProperties(aliasName);
            //Assert.IsType<GetAllAliasPropertiesResponseModel>(response);
        }

        /// <summary>
        /// Test UpdateAliasProperties
        /// </summary>
        [Fact]
        public void UpdateAliasPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aliasName = null;
            //UpdateAliasPropertiesRequestBodyModel updateAliasPropertiesRequestBodyModel = null;
            //var response = instance.UpdateAliasProperties(aliasName, updateAliasPropertiesRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }
    }
}
