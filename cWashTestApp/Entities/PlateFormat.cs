using System.ComponentModel;

namespace cWashTestApp.Entities
{
    /// <summary>
    /// Format of the plate in number of wells.
    /// </summary>
    public enum PlateFormat
    {
        [Description("96-well")]
        Well_96,
        [Description("384-well")]
        Well_384,
        [Description("1536-well")]
        Well_1536,
        NoPlate
    }
}
