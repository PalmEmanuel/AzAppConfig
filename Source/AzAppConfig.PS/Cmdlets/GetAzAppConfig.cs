using PipeHow.AzAppConfig.Core;
using System.Collections;
using System.Linq;
using System.Management.Automation;

namespace PipeHow.AzAppConfig.Cmdlets
{
    /// <summary>
    /// <para type="synopsis">Gets configuration from an Azure App Configuration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzAppConfig")]
    public class GetAzAppConfig : AzAppConfigCommandBase
    {
        /// <summary>
        /// The process step of the pipeline.
        /// </summary>
        protected override void ProcessRecord()
        {
            // Output the list of key value pairs as hashtable
            WriteObject(new Hashtable(Configuration.ToDictionary(
                kv => kv.Key,
                kv => kv.Value)));
        }
    }
}
