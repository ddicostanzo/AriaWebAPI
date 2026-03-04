using System;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to represent an integer value that can be serialized into the Aria Access API JSON format.
    /// </summary>
    public class JsonInt : AriaAccessObject
    {
        /// <summary>
        /// Gets or sets the integer value. A value of <see cref="int.MinValue"/> indicates the value has not been set.
        /// </summary>
        public int Value { get; set; } = int.MinValue;

        /// <summary>Gets a value indicating whether this instance has been explicitly set.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsSet => Value != int.MinValue;

        public JsonInt(int val) : base("WholeNumber:http://services.varian.com/AriaWebConnect/Common")
        {
            Value = val;
        }
        public JsonInt() : base("WholeNumber:http://services.varian.com/AriaWebConnect/Common") { }
    }
}
