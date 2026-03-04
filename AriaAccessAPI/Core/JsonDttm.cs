using System;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to serialize DateTime objects to JSON in a specific format.
    /// </summary>
    public class JsonDttm : AriaAccessObject
    {
        public JsonDttm() : base("String:http://services.varian.com/AriaWebConnect/Common")
        {
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
                if (!DateTime.TryParse(value, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _date))
                {
                    // Keep _date as default if parsing fails — callers should check ShortDateFlag or use the string value
                    _date = DateTime.MinValue;
                }
            }
        }


    }
}
