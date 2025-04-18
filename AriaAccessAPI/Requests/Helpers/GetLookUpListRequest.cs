using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to create a request for the GetLookUpList method in the Aria Access API.
    /// </summary>
    public class GetLookUpListRequest : AriaAccessObject
    {
        private LookUpListType lookUpTypeEnum;
        public JsonString LookUpLanguage { get; set; }
        public JsonString LookUpType { get { return new JsonString(lookUpTypeEnum.ToString()); } }
        public AriaAccessAttribute[] Attributes { get; set; }

        public GetLookUpListRequest(LookUpListType type, string language = "ENU") :
            base("GetLookUpListRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            LookUpLanguage = new JsonString(language);
            lookUpTypeEnum = type;
        }
    }
}
