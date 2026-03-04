using System;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// The JsonBool data type. When this object is serialized, it provides the appropriate interface for the Aria Access API.
    /// </summary>
    public class JsonBool : AriaAccessObject
    {
        public bool Value { get; set; }
        public JsonBool(bool v): base("Boolean:http://services.varian.com/AriaWebConnect/Common")
        {
            Value = v;
        }
        public JsonBool() : base("Boolean:http://services.varian.com/AriaWebConnect/Common") { }

    }
}
