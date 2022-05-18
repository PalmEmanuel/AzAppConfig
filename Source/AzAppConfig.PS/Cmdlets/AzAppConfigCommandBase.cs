using PipeHow.AzAppConfig.Core;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace PipeHow.AzAppConfig.Cmdlets
{
    /// <summary>
    /// The base class of the commands, containing connection parameters.
    /// </summary>
    public class AzAppConfigCommandBase : PSCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "ConnectionString")]
        [ValidateNotNullOrEmpty()]
        public string ConnectionString { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "EndpointToken")]
        [ValidateNotNullOrEmpty()]
        [ValidatePattern("https://.*")]
        public Uri Endpoint { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "EndpointToken")]
        [ValidateNotNullOrEmpty()]
        public string Token { get; set; }

        public KeyValuePair<string, string>[] Configuration { get; private set; }

        /// <summary>
        /// The process step of the pipeline.
        /// </summary>
        protected override void BeginProcessing()
        {
            WriteDebug("ParameterSetName: " + ParameterSetName);
            
            switch (ParameterSetName)
            {
                case "ConnectionString":
                    Configuration = AzAppConfigService.Connect(ConnectionString);
                    break;
                case "EndpointToken":
                    Configuration = AzAppConfigService.Connect(Endpoint, Token);
                    break;
                default:
                    throw new ArgumentException($"Unknown parameter set '{ParameterSetName}' was used!");
            }
        }
    }
}
