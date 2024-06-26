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
    ///  Class for testing InboxServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InboxServiceApiTests : IDisposable
    {
        private InboxServiceApi instance;

        public InboxServiceApiTests()
        {
            instance = new InboxServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InboxServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InboxServiceApi
            //Assert.IsType<InboxServiceApi>(instance);
        }

        /// <summary>
        /// Test InboxServiceDeleteInbox
        /// </summary>
        [Fact]
        public void InboxServiceDeleteInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name2 = null;
            //var response = instance.InboxServiceDeleteInbox(name2);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test InboxServiceListInboxes
        /// </summary>
        [Fact]
        public void InboxServiceListInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? user = null;
            //var response = instance.InboxServiceListInboxes(user);
            //Assert.IsType<V1ListInboxesResponse>(response);
        }

        /// <summary>
        /// Test InboxServiceUpdateInbox
        /// </summary>
        [Fact]
        public void InboxServiceUpdateInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string inboxName = null;
            //InboxServiceUpdateInboxRequest inbox = null;
            //var response = instance.InboxServiceUpdateInbox(inboxName, inbox);
            //Assert.IsType<V1Inbox>(response);
        }
    }
}
