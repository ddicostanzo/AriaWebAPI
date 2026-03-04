using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// The PrescriptionVolumeInfo class represents a prescription volume information object in the Aria Access API.
    /// </summary>
    public class PrescriptionVolumeInfo : AriaAccessObject
    {
        public PrescriptionVolumeInfo() : base("PrescriptionVolumeInfo:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonFloat Depth { get; set; }
        public JsonFloat DosePerFraction { get; set; }
        public JsonFloat IsodoseLine { get; set; }
        public JsonString PrescribeTo { get; set; }
        public JsonString StructureName { get; set; }
        public JsonFloat TotalDose { get; set; }
    }
}
