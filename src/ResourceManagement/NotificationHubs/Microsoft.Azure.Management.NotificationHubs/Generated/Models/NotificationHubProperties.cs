// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// NotificationHub properties.
    /// </summary>
    public partial class NotificationHubProperties
    {
        /// <summary>
        /// Initializes a new instance of the NotificationHubProperties class.
        /// </summary>
        public NotificationHubProperties() { }

        /// <summary>
        /// Initializes a new instance of the NotificationHubProperties class.
        /// </summary>
        public NotificationHubProperties(string name = default(string), string registrationTtl = default(string), IList<SharedAccessAuthorizationRuleProperties> authorizationRules = default(IList<SharedAccessAuthorizationRuleProperties>), ApnsCredential apnsCredential = default(ApnsCredential), WnsCredential wnsCredential = default(WnsCredential), GcmCredential gcmCredential = default(GcmCredential), MpnsCredential mpnsCredential = default(MpnsCredential), AdmCredential admCredential = default(AdmCredential), BaiduCredential baiduCredential = default(BaiduCredential))
        {
            Name = name;
            RegistrationTtl = registrationTtl;
            AuthorizationRules = authorizationRules;
            ApnsCredential = apnsCredential;
            WnsCredential = wnsCredential;
            GcmCredential = gcmCredential;
            MpnsCredential = mpnsCredential;
            AdmCredential = admCredential;
            BaiduCredential = baiduCredential;
        }

        /// <summary>
        /// The NotificationHub name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The RegistrationTtl of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "registrationTtl")]
        public string RegistrationTtl { get; set; }

        /// <summary>
        /// The AuthorizationRules of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "authorizationRules")]
        public IList<SharedAccessAuthorizationRuleProperties> AuthorizationRules { get; set; }

        /// <summary>
        /// The ApnsCredential of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "apnsCredential")]
        public ApnsCredential ApnsCredential { get; set; }

        /// <summary>
        /// The WnsCredential of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "wnsCredential")]
        public WnsCredential WnsCredential { get; set; }

        /// <summary>
        /// The GcmCredential of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "gcmCredential")]
        public GcmCredential GcmCredential { get; set; }

        /// <summary>
        /// The MpnsCredential of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "mpnsCredential")]
        public MpnsCredential MpnsCredential { get; set; }

        /// <summary>
        /// The AdmCredential of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "admCredential")]
        public AdmCredential AdmCredential { get; set; }

        /// <summary>
        /// The BaiduCredential of the created NotificationHub
        /// </summary>
        [JsonProperty(PropertyName = "baiduCredential")]
        public BaiduCredential BaiduCredential { get; set; }

    }
}
