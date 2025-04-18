using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to get patient diagnoses from the Aria Access API.
    /// </summary>
    public class GetPatientDiagnosesRequest : AriaAccessObject
    {
        public JsonString PatientId { get; set; }
        public JsonInt PatientDiagnosisId { get; set; }
        public GetPatientDiagnosesRequest(string mrn, int? diagnosisid) : 
            base("GetPatientDiagnosesRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            PatientId = new JsonString(mrn);
            if(diagnosisid.HasValue)
                PatientDiagnosisId = new JsonInt(diagnosisid.Value);
        }
    }
}
