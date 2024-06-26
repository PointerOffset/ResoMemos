/*
 * api/v1/activity_service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing WorkspaceServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkspaceServiceApiTests : IDisposable
    {
        private WorkspaceServiceApi instance;

        public WorkspaceServiceApiTests()
        {
            instance = new WorkspaceServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkspaceServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WorkspaceServiceApi
            //Assert.IsType<WorkspaceServiceApi>(instance);
        }

        /// <summary>
        /// Test WorkspaceServiceGetWorkspaceProfile
        /// </summary>
        [Fact]
        public void WorkspaceServiceGetWorkspaceProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.WorkspaceServiceGetWorkspaceProfile();
            //Assert.IsType<V1WorkspaceProfile>(response);
        }
    }
}