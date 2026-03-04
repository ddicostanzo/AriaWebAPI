using System.Text.Json.Serialization;

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
        public string __type { get; private set; }
        public AriaAccessObject(string type)
        {
            __type = type;
        }
    }
}
