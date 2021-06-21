using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cytena.CWash.ClientExample.Entities
{
    /// <summary>
    /// Command object that is sent to the CWash server for execution.
    /// Important: Do not change the structure of this class.
    /// </summary>
    public class Command
    {
        /// <summary>
        /// Name/Id of the command. Defined by the firmware.
        /// </summary>
        public string Name { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
        public CommandType Type { get; set; }
        
        /// <summary>
        /// List of command parameters.
        /// </summary>
        public List<string> Parameters { get; set; }

        public Command()
        {
            //Parameters = new List<string>();
            //Type = CommandType.Command;
        }
    }
}
