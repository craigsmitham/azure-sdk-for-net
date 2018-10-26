// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// Common VNet properties used for query and creation/update request.
    /// </summary>
    public partial class VNetCommonFields
    {
        private IList<string> _dnsServers;
        
        /// <summary>
        /// Optional. A list of DNS server IP addresses.
        /// </summary>
        public IList<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }
        
        private string _gatewayIp;
        
        /// <summary>
        /// Optional. A gateway IP address.
        /// </summary>
        public string GatewayIp
        {
            get { return this._gatewayIp; }
            set { this._gatewayIp = value; }
        }
        
        private string _gatewaySubnet;
        
        /// <summary>
        /// Optional. A gateway subnet address.
        /// </summary>
        public string GatewaySubnet
        {
            get { return this._gatewaySubnet; }
            set { this._gatewaySubnet = value; }
        }
        
        private GatewayType _gatewayType;
        
        /// <summary>
        /// Optional. Gateway type.
        /// </summary>
        public GatewayType GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }
        
        private IList<string> _localAddressSpaces;
        
        /// <summary>
        /// Optional. A list of local network CIDR address spaces.
        /// </summary>
        public IList<string> LocalAddressSpaces
        {
            get { return this._localAddressSpaces; }
            set { this._localAddressSpaces = value; }
        }
        
        private string _region;
        
        /// <summary>
        /// Optional. Virtual network region.
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }
        
        private IList<string> _vnetAddressSpaces;
        
        /// <summary>
        /// Optional. A list of virtual network CIDR address spaces.
        /// </summary>
        public IList<string> VnetAddressSpaces
        {
            get { return this._vnetAddressSpaces; }
            set { this._vnetAddressSpaces = value; }
        }
        
        private string _vpnAddress;
        
        /// <summary>
        /// Optional. IP address of a VPN device.
        /// </summary>
        public string VpnAddress
        {
            get { return this._vpnAddress; }
            set { this._vpnAddress = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VNetCommonFields class.
        /// </summary>
        public VNetCommonFields()
        {
            this.DnsServers = new LazyList<string>();
            this.LocalAddressSpaces = new LazyList<string>();
            this.VnetAddressSpaces = new LazyList<string>();
        }
    }
}