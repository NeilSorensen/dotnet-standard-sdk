/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using IBM.Cloud.SDK.Core;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IBM.Watson.Discovery.v1.Model
{
    /// <summary>
    /// Object describing a specific gateway.
    /// </summary>
    public class Gateway : BaseModel
    {
        /// <summary>
        /// The current status of the gateway. `connected` means the gateway is connected to the remotly installed
        /// gateway. `idle` means this gateway is not currently in use.
        /// </summary>
        /// <value>
        /// The current status of the gateway. `connected` means the gateway is connected to the remotly installed
        /// gateway. `idle` means this gateway is not currently in use.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum CONNECTED for connected
            /// </summary>
            [EnumMember(Value = "connected")]
            CONNECTED,
            
            /// <summary>
            /// Enum IDLE for idle
            /// </summary>
            [EnumMember(Value = "idle")]
            IDLE
        }

        /// <summary>
        /// The current status of the gateway. `connected` means the gateway is connected to the remotly installed
        /// gateway. `idle` means this gateway is not currently in use.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The gateway ID of the gateway.
        /// </summary>
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayId { get; set; }
        /// <summary>
        /// The user defined name of the gateway.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// The generated **token** for this gateway. The value of this field is used when configuring the remotly
        /// installed gateway.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
        /// <summary>
        /// The generated **token_id** for this gateway. The value of this field is used when configuring the remotly
        /// installed gateway.
        /// </summary>
        [JsonProperty("token_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenId { get; set; }
    }

}
