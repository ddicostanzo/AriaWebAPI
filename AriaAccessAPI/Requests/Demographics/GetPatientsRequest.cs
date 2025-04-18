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
    /// The class the instantiates the GetPatientsRequest object for sending to the Aria API.
    /// </summary>
    public class GetPatientsRequest : AriaAccessObject
    {
        public JsonString FirstName { get; set; } = new JsonString(64);
        public JsonString LastName { get; set; } = new JsonString(64);
        public JsonString PatientId1 { get; set; } = new JsonString(25);
        public JsonString PatientId2 { get; set; } = new JsonString(string.Empty ,25);
        
        private MatchingCriteria lookUpTypeEnum;
        public JsonString MatchingCriteria { get { return new JsonString(lookUpTypeEnum.ToString()); } }
        public JsonBool IsMultipleNamesRequired { get; set; } = new JsonBool(false);

        public GetPatientsRequest(string lastname, string firstname, string patid1, MatchingCriteria criteria):
            base("GetPatientsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            LastName.Value = lastname;
            FirstName.Value = firstname;
            PatientId1.Value = patid1;
            lookUpTypeEnum = criteria;
        }
    }
}
