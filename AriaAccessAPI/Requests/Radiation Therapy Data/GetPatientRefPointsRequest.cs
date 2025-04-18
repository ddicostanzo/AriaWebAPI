using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to get patient reference points in the Aria Access API.
    /// </summary>
    public class GetPatientRefPointsRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString PatientId { get; set; }

        public GetPatientRefPointsRequest(string mrn) :
            base("GetPatientRefPointsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            PatientId = new JsonString(mrn);
        }
    }
}
