using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class represents an associated resource in the Aria Access API that can be serialized or deserialized appropriately.
    /// </summary>
    public class AssociatedResource : AriaAccessObject
    {
        public AssociatedResource() : base("ResourceInfo:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString ResourceID { get; set; }
        public JsonString ResourceType { get; set; }
    }
}
