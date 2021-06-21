using System.Collections.Generic;

namespace Cytena.CWash.ClientExample.Entities
{
    /// <summary>
    /// Protocol object that is sent to the CWash server for execution.
    /// Important: Do not change the structure of this class.
    /// </summary>
    public class Protocol
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public PlateFormat PlateFormat { get; set; }
        public string Author { get; set; }
        public string Comments { get; set; }
        public string CWashVersion { get; set; }
        public List<Command> Commands { get; set; }

        public Protocol()
        {
            Commands = new List<Command>();
        }
    }
}
