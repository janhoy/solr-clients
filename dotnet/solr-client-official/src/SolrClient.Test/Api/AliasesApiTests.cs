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
    ///  Class for testing AliasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AliasesApiTests : IDisposable
    {
        private AliasesApi instance;

        public AliasesApiTests()
        {
            instance = new AliasesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AliasesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AliasesApi
            //Assert.IsType<AliasesApi>(instance);
        }

        /// <summary>
        /// Test CreateAlias
        /// </summary>
        [Fact]
        public void CreateAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateAliasRequestBodyModel? createAliasRequestBodyModel = null;
            //var response = instance.CreateAlias(createAliasRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test DeleteAlias
        /// </summary>
        [Fact]
        public void DeleteAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aliasName = null;
            //string? async = null;
            //var response = instance.DeleteAlias(aliasName, async);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test GetAliasByName
        /// </summary>
        [Fact]
        public void GetAliasByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aliasName = null;
            //var response = instance.GetAliasByName(aliasName);
            //Assert.IsType<GetAliasByNameResponseModel>(response);
        }

        /// <summary>
        /// Test GetAliases
        /// </summary>
        [Fact]
        public void GetAliasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAliases();
            //Assert.IsType<ListAliasesResponseModel>(response);
        }
    }
}
