using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to represent a floating point number that can be serialized to the Aria Access API format.
    /// </summary>
    public class JsonFloat : AriaAccessObject
    {
        public double Value { get; set; } = double.NaN;
        public JsonFloat() : base("RealNumber:http://services.varian.com/AriaWebConnect/Common") { }
        public JsonFloat(double val) : base("RealNumber:http://services.varian.com/AriaWebConnect/Common")
        {
            Value = val;
        }
    }
}
