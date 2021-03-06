// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The set of properties specific to the Azure ML web service resource.
    /// </summary>
    public partial class WebServiceProperties
    {
        /// <summary>
        /// Initializes a new instance of the WebServiceProperties class.
        /// </summary>
        public WebServiceProperties() { }

        /// <summary>
        /// Initializes a new instance of the WebServiceProperties class.
        /// </summary>
        public WebServiceProperties(string title = default(string), string description = default(string), DateTime? createdOn = default(DateTime?), DateTime? modifiedOn = default(DateTime?), string provisioningState = default(string), WebServiceKeys keys = default(WebServiceKeys), bool? readOnlyProperty = default(bool?), string swaggerLocation = default(string), bool? exposeSampleData = default(bool?), RealtimeConfiguration realtimeConfiguration = default(RealtimeConfiguration), DiagnosticsConfiguration diagnostics = default(DiagnosticsConfiguration), StorageAccount storageAccount = default(StorageAccount), MachineLearningWorkspace machineLearningWorkspace = default(MachineLearningWorkspace), CommitmentPlan commitmentPlan = default(CommitmentPlan), ServiceInputOutputSpecification input = default(ServiceInputOutputSpecification), ServiceInputOutputSpecification output = default(ServiceInputOutputSpecification), ExampleRequest exampleRequest = default(ExampleRequest), IDictionary<string, AssetItem> assets = default(IDictionary<string, AssetItem>), IDictionary<string, string> parameters = default(IDictionary<string, string>))
        {
            Title = title;
            Description = description;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            ProvisioningState = provisioningState;
            Keys = keys;
            ReadOnlyProperty = readOnlyProperty;
            SwaggerLocation = swaggerLocation;
            ExposeSampleData = exposeSampleData;
            RealtimeConfiguration = realtimeConfiguration;
            Diagnostics = diagnostics;
            StorageAccount = storageAccount;
            MachineLearningWorkspace = machineLearningWorkspace;
            CommitmentPlan = commitmentPlan;
            Input = input;
            Output = output;
            ExampleRequest = exampleRequest;
            Assets = assets;
            Parameters = parameters;
        }

        /// <summary>
        /// The title of the Azure ML web service.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The description of the Azure ML web service.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The moment of time the Azure ML web service was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdOn")]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The moment of time the web service was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedOn")]
        public DateTime? ModifiedOn { get; private set; }

        /// <summary>
        /// The web service resource's provisioning state. Possible values
        /// include: 'Unknown', 'Provisioning', 'Succeeded', 'Failed',
        /// 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// The set of access keys for the web service. If not specified at
        /// creation time (PUT), they will be generated automatically by the
        /// resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "keys")]
        public WebServiceKeys Keys { get; set; }

        /// <summary>
        /// If true, the web service can no longer be updated / patched, only
        /// removed. Otherwise, the service resource supports changes.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// The uri for the swagger spec associated with this web service.
        /// </summary>
        [JsonProperty(PropertyName = "swaggerLocation")]
        public string SwaggerLocation { get; private set; }

        /// <summary>
        /// Flag that controls whether to expose sample data or not in the web
        /// service's swagger definition.
        /// </summary>
        [JsonProperty(PropertyName = "exposeSampleData")]
        public bool? ExposeSampleData { get; set; }

        /// <summary>
        /// Configuration for the service's realtime endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "realtimeConfiguration")]
        public RealtimeConfiguration RealtimeConfiguration { get; set; }

        /// <summary>
        /// Settings controlling the diagnostics traces collection for the web
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public DiagnosticsConfiguration Diagnostics { get; set; }

        /// <summary>
        /// The storage account associated with the service. This is used to
        /// store both datasets and diagnostic traces. This information is
        /// required at creation time (PUT) and only the key is updateable
        /// after that. The account credentials are hidden on a GET web
        /// service call.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccount")]
        public StorageAccount StorageAccount { get; set; }

        /// <summary>
        /// This is only populated at creation time (PUT) for web services
        /// originating from an AzureML Studio experiment.
        /// </summary>
        [JsonProperty(PropertyName = "machineLearningWorkspace")]
        public MachineLearningWorkspace MachineLearningWorkspace { get; set; }

        /// <summary>
        /// The commitment plan associated with this web service. This is
        /// required to be specified at creation time (PUT) and is not
        /// updateable afterwards.
        /// </summary>
        [JsonProperty(PropertyName = "commitmentPlan")]
        public CommitmentPlan CommitmentPlan { get; set; }

        /// <summary>
        /// Swagger schema for the service's input(s), as applicable.
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public ServiceInputOutputSpecification Input { get; set; }

        /// <summary>
        /// Swagger schema for the service's output(s), as applicable.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public ServiceInputOutputSpecification Output { get; set; }

        /// <summary>
        /// Sample request data for each of the service's inputs, as
        /// applicable.
        /// </summary>
        [JsonProperty(PropertyName = "exampleRequest")]
        public ExampleRequest ExampleRequest { get; set; }

        /// <summary>
        /// Set of assets associated with the web service.
        /// </summary>
        [JsonProperty(PropertyName = "assets")]
        public IDictionary<string, AssetItem> Assets { get; set; }

        /// <summary>
        /// The set of global parameters values defined for the web service,
        /// given as a global parameter name to default value map. If no
        /// default value is specified, the parameter is considered to be
        /// required.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.RealtimeConfiguration != null)
            {
                this.RealtimeConfiguration.Validate();
            }
            if (this.Diagnostics != null)
            {
                this.Diagnostics.Validate();
            }
            if (this.MachineLearningWorkspace != null)
            {
                this.MachineLearningWorkspace.Validate();
            }
            if (this.CommitmentPlan != null)
            {
                this.CommitmentPlan.Validate();
            }
            if (this.Input != null)
            {
                this.Input.Validate();
            }
            if (this.Output != null)
            {
                this.Output.Validate();
            }
            if (this.Assets != null)
            {
                foreach (var valueElement in this.Assets.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
