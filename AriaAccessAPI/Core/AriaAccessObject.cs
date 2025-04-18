using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// The foundational base class for all Aria Access Objects
    /// </summary>
    public class AriaAccessObject
    {
        /// <summary>
        /// The type of the object that should be inherited and overridden by all subclasses.
        /// </summary>
        [JsonPropertyOrder(-2)]
        public string __type { get; set; }
        public AriaAccessObject(string type)
        {
            __type = type;
        }
    }
}
