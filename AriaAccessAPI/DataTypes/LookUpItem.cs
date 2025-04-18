using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
