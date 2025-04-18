using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to represent an integer value that can be serialized into the Aria Access API JSON format.
    /// </summary>
    public class JsonInt : AriaAccessObject
    {
        public int Value { get; set; } = int.MinValue;
        public JsonInt(int val) : base("WholeNumber:http://services.varian.com/AriaWebConnect/Common")
        {
            Value = val;
        }
        public JsonInt() : base("WholeNumber:http://services.varian.com/AriaWebConnect/Common") { }
    }
}
