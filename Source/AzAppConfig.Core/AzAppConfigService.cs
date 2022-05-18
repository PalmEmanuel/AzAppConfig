using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PipeHow.AzAppConfig.Core
{
    public static class AzAppConfigService
    {
        /// <summary>
        /// Create a connection to the app configuration using a connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public static KeyValuePair<string,string>[] Connect(string connectionString)
        {
            return new ConfigurationBuilder().AddAzureAppConfiguration(connectionString).Build().AsEnumerable().ToArray();
        }

        /// <summary>
        /// Create a connection to the app configuration using a token.
        /// </summary>
        /// <param name="endpoint">The endpoint of the app configuration.</param>
        /// <param name="token">The token to use for authentication.</param>
        public static KeyValuePair<string, string>[] Connect(Uri endpoint, string token)
        {
            return new ConfigurationBuilder().AddAzureAppConfiguration(options =>
            {
                options.Connect(endpoint, new ExternalTokenCredential(token, DateTimeOffset.Now.AddDays(1)));
            }).Build().AsEnumerable().ToArray();
        }
    }
}
