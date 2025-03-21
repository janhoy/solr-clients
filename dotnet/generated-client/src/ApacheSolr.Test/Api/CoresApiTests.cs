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

using ApacheSolr.Client;
using ApacheSolr.Api;
// uncomment below to import models
//using ApacheSolr.Model;

namespace ApacheSolr.Test.Api
{
    /// <summary>
    ///  Class for testing CoresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CoresApiTests : IDisposable
    {
        private CoresApi instance;

        public CoresApiTests()
        {
            instance = new CoresApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CoresApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CoresApi
            //Assert.IsType<CoresApi>(instance);
        }

        /// <summary>
        /// Test InstallCoreData
        /// </summary>
        [Fact]
        public void InstallCoreDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //InstallCoreDataRequestBodyModel? installCoreDataRequestBodyModel = null;
            //var response = instance.InstallCoreData(coreName, installCoreDataRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test MergeIndexes
        /// </summary>
        [Fact]
        public void MergeIndexesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //MergeIndexesRequestBodyModel? mergeIndexesRequestBodyModel = null;
            //var response = instance.MergeIndexes(coreName, mergeIndexesRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test ReloadCore
        /// </summary>
        [Fact]
        public void ReloadCoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //var response = instance.ReloadCore(coreName);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test RenameCore
        /// </summary>
        [Fact]
        public void RenameCoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //RenameCoreRequestBodyModel? renameCoreRequestBodyModel = null;
            //var response = instance.RenameCore(coreName, renameCoreRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test RestoreCore
        /// </summary>
        [Fact]
        public void RestoreCoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //RestoreCoreRequestBodyModel? restoreCoreRequestBodyModel = null;
            //var response = instance.RestoreCore(coreName, restoreCoreRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test SwapCores
        /// </summary>
        [Fact]
        public void SwapCoresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //SwapCoresRequestBodyModel? swapCoresRequestBodyModel = null;
            //var response = instance.SwapCores(coreName, swapCoresRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }

        /// <summary>
        /// Test UnloadCore
        /// </summary>
        [Fact]
        public void UnloadCoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //UnloadCoreRequestBodyModel? unloadCoreRequestBodyModel = null;
            //var response = instance.UnloadCore(coreName, unloadCoreRequestBodyModel);
            //Assert.IsType<SolrJerseyResponseModel>(response);
        }
    }
}
