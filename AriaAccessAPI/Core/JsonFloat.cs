using System;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to represent a floating point number that can be serialized to the Aria Access API format.
    /// </summary>
    public class JsonFloat : AriaAccessObject
    {
        /// <summary>
        /// Gets or sets the floating-point value. A value of <see cref="double.NaN"/> indicates the value has not been set.
        /// </summary>
        public double Value { get; set; } = double.NaN;

        /// <summary>Gets a value indicating whether this instance has been explicitly set.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsSet => !double.IsNaN(Value);

        public JsonFloat() : base("RealNumber:http://services.varian.com/AriaWebConnect/Common") { }
        public JsonFloat(double val) : base("RealNumber:http://services.varian.com/AriaWebConnect/Common")
        {
            Value = val;
        }
    }
}
