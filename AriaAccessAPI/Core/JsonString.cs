using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to represent a string with a maximum length that can be serialized in the Aria Access API JSON format.
    /// </summary>
    public class JsonString : AriaAccessObject
    {
        public int MaxLength { get; set; } = 65535;
        private string _Value;
        public JsonString(string s) : base("String:http://services.varian.com/AriaWebConnect/Common")
        {
            _Value = s;
        }
        public JsonString() : base("String:http://services.varian.com/AriaWebConnect/Common") { }
        public JsonString(int len) : base("String:http://services.varian.com/AriaWebConnect/Common") { MaxLength = len; }
        public JsonString(string s, int len) : base("String:http://services.varian.com/AriaWebConnect/Common")
        {
            _Value = s;
            MaxLength = len;
        }
        public string Value
        {
            get { return (_Value == null) ? null : _Value; }
            set
            {
                if (value == null) return;
                if (value.Length > MaxLength)
                    throw new ArgumentException("The provided value has length greater than max length of this string.");
                _Value = value;
            }
        }
        
    }
}
