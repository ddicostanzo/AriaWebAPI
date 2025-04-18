using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// The PrescriptionVolumeInfo class represents a prescription volume information object in the Aria Access API.
    /// </summary>
    public class PrescriptionVolumeInfo : AriaAccessObject
    {
        public PrescriptionVolumeInfo() : base("PrescriptionVolumeInfo:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString Depth { get; set; }
        public JsonString DosePerFraction { get; set; }
        public JsonString IsodoseLine { get; set; }
        public JsonString PrescribeTo { get; set; }
        public JsonString StructureName { get; set; }
        public JsonString TotalDose { get; set; }
    }
}