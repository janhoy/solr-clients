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
    ///  Class for testing ReplicationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReplicationApiTests : IDisposable
    {
        private ReplicationApi instance;

        public ReplicationApiTests()
        {
            instance = new ReplicationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReplicationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReplicationApi
            //Assert.IsType<ReplicationApi>(instance);
        }

        /// <summary>
        /// Test FetchFileList
        /// </summary>
        [Fact]
        public void FetchFileListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //long generation = null;
            //var response = instance.FetchFileList(coreName, generation);
            //Assert.IsType<FileListResponseModel>(response);
        }

        /// <summary>
        /// Test FetchIndexVersion
        /// </summary>
        [Fact]
        public void FetchIndexVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string coreName = null;
            //var response = instance.FetchIndexVersion(coreName);
            //Assert.IsType<IndexVersionResponseModel>(response);
        }
    }
}
