using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class is used to represent a LookUpItem in the Aria Access API.
    /// </summary>
    public class LookUpItem : AriaAccessObject
    {
        public LookUpItem() : base("LookUpItem:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString Expression1 { get; set; }
        public JsonString Expression2 { get; set; }
        public JsonString Expression3 { get; set; }
        public JsonString Language { get; set; }
        public JsonString SubType { get; set; }
        public JsonString Type { get; set; }
        public JsonString Value { get; set; }

    }
}
