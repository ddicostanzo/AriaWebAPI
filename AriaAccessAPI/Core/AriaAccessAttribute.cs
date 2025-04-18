using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// The AriaAccessAttribute class represents an attribute in the Aria Access API. This is a base class.
    /// </summary>
    public class AriaAccessAttribute : AriaAccessObject
    {
        public AriaAccessAttribute() : base (string.Empty) { }
        /// <summary>
        /// The name of the attribute.
        /// </summary>
        public JsonString Name { get; set; }
        /// <summary>
        /// The value of the attribute in JsonString format
        /// </summary>
        public JsonString Value { get; set; }
    }
}
