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
    /// This class is used to represent a request to get the diagnosis lookup list.
    /// </summary>
    public class GetDiagnosisLookUpListRequest : AriaAccessObject
    {
        private DiagnosisLookUpType lookUpTypeEnum;
        public JsonString LookUpLanguage { get; set; } = new JsonString();
        public JsonString LookUpType { get { return new JsonString(lookUpTypeEnum.ToString()); } }
        public JsonString Attributes { get; set; }

        public GetDiagnosisLookUpListRequest(DiagnosisLookUpType lookUpType, string language) :
            base("GetDiagnosisLookUpListRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            lookUpTypeEnum = lookUpType;
            LookUpLanguage.Value = language;

        }
    }
}
