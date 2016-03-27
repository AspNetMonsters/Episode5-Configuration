using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationSample.Configuration
{
    public class AzureStorageSettings
    {
        public string AzureStorage { get; set; }
        public bool EnableAzureQueueService { get; set; }
    }
}
