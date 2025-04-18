using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class is used to represent a diagnosis lookup item in the Aria Access API.
    /// </summary>
    public class DiagnosisLookUpItem : AriaAccessObject
    {
        public JsonString Description { get; set; }
        public JsonString Language { get; set; }
        public JsonString Value { get; set; }

        /// <summary>
        /// Constructor for the DiagnosisLookUpItem class.
        /// </summary>
        /// <param name="desc">The description to search</param>
        /// <param name="lang">The language to search</param>
        /// <param name="val">The value to lookup</param>
        public DiagnosisLookUpItem(string desc, string lang, string val) : base("DiagnosisLookUpItem:http://services.varian.com/AriaWebConnect/Link")
        {
            Description = new JsonString(desc);
            Language = new JsonString(lang);
            Value = new JsonString(val);
        }
        public DiagnosisLookUpItem() : base ("DiagnosisLookUpItem:http://services.varian.com/AriaWebConnect/Link") {  }
    }
}
