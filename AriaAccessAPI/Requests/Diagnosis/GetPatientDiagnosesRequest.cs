using AriaWebAPI.AriaAccessAPI.Core;
using System;

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
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            PatientId = new JsonString(mrn);
            if(diagnosisid.HasValue)
                PatientDiagnosisId = new JsonInt(diagnosisid.Value);
        }
    }
}
