using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class is used to represent a patient's name in the Aria Access API JSON format.
    /// </summary>
    public class PatientName: AriaAccessObject
    {
        public PatientName() : base("PatientName:http://services.varian.com/AriaWebConnect/Patient") { }
        public JsonString FirstName { get; set; } = new JsonString(64);
        public JsonString MiddleName { get; set; } = new JsonString();
        public JsonString NameSuffix { get; set; } = new JsonString();
        public JsonString Honorific { get; set; } = new JsonString();
        public JsonString NameType { get; set; } = new JsonString();
        public JsonString NameRepresentationCode { get; set; } = new JsonString();
        public JsonInt NameSelectedForDisplay { get; set; } = new JsonInt();
    }
}
