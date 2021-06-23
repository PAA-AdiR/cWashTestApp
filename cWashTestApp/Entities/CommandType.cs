using System.Runtime.Serialization;

namespace cWashTestApp.Entities
{
    /// <summary>
    /// Type of the Command object. Action type Commands are translated into a set of commands on the server before execution.
    /// Command type Commands are executed as sent.
    /// </summary>
    public enum CommandType
    {
        //[EnumMember(Value = "command")]
        //Command,
        //[EnumMember(Value = "action")]
        //Action
    }
}
