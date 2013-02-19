﻿using System;
using JsonFx.Json;

namespace Auth0
{
    public class Connection
    {
        public Connection(string strategy, string tenantDomain, string name = null)
        {
            if (strategy == null) throw new ArgumentNullException("strategy");
            if (tenantDomain == null) throw new ArgumentNullException("tenantDomain");
            Name = string.IsNullOrEmpty(name) ? tenantDomain : name;
            Strategy = strategy;
            Options = new ConnectionOptions { TenantDomain = tenantDomain };
            Enabled = true;
        }

        public Connection()
        {
            Options = new ConnectionOptions();
        }

        [JsonName("name")]
        public string Name { get; set; }

        [JsonName("strategy")]
        public string Strategy { get; set; }
        
        [JsonName("options")]
        public ConnectionOptions Options { get; set; }
        
        [JsonName("provisioning_ticket")]
        public string ProvisioningTicket { get; set; }

        [JsonName("provisioning_ticket_url")]
        public string ProvisioningTicketUrl { get; set; }

        [JsonName("status")]
        public bool Enabled { get; set; }
    }

    public class ConnectionOptions
    {
        [JsonName("tenant_domain")]
        public string TenantDomain { get; set; }

        [JsonName("adfs_server")]
        public string AdfsServer { get; set; }
    }
}
