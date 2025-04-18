using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// The GetPatientDiagnosesResponse class represents a response object for retrieving patient diagnoses in the Aria Access API.
    /// </summary>
    public class GetPatientDiagnosesResponse : AriaAccessObject
    {
        public GetPatientDiagnosesResponse() : base("GetPatientDiagnosesResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public DiagnosisResponse[] Diagnosis { get; set; }
        
    }
}
