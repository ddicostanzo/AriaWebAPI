using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to serialize DateTime objects to JSON in a specific format.
    /// </summary>
    public class JsonDttm : AriaAccessObject
    {
        public JsonDttm() : base("String:http://services.varian.com/AriaWebConnect/Common") 
        {
            Console.WriteLine();
        
        }
        public JsonDttm(DateTime dttm, bool shortdate = false) : base("String:http://services.varian.com/AriaWebConnect/Common")
        {
            _date = dttm;
            ShortDateFlag = shortdate;
        }

        private DateTime _date;
        private string _fulldatetimestring { get { return _date.ToString("yyyy-MM-ddTHH:mm:sszzz"); } }
        private string _dateonlystring { get { return _date.ToString("yyyy-MM-dd"); } }
        private bool ShortDateFlag { get; set; }
        public string Value
        {
            get { return (ShortDateFlag) ? _dateonlystring : _fulldatetimestring; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                DateTime.TryParse(value, out _date);
            }
        }


    }
}
