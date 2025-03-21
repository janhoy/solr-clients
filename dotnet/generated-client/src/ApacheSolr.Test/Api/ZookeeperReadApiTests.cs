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
    ///  Class for testing ZookeeperReadApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ZookeeperReadApiTests : IDisposable
    {
        private ZookeeperReadApi instance;

        public ZookeeperReadApiTests()
        {
            instance = new ZookeeperReadApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ZookeeperReadApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ZookeeperReadApi
            //Assert.IsType<ZookeeperReadApi>(instance);
        }

        /// <summary>
        /// Test ListNodes
        /// </summary>
        [Fact]
        public void ListNodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string zkPath = null;
            //bool? children = null;
            //var response = instance.ListNodes(zkPath, children);
            //Assert.IsType<ZooKeeperListChildrenResponseModel>(response);
        }

        /// <summary>
        /// Test ReadNode
        /// </summary>
        [Fact]
        public void ReadNodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string zkPath = null;
            //var response = instance.ReadNode(zkPath);
            //Assert.IsType<ZooKeeperFileResponseModel>(response);
        }
    }
}
