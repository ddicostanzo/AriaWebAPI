using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// This class is used to represent a response from the GetPatients method in the Aria Access API.
    /// </summary>
    public class GetPatientsResponse : AriaAccessObject
    {
        public GetPatientsResponse() : base("GetPatientsResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public PatientResponse[] Patients { get; set; }
        public JsonString Warning { get; set; }
    }
}
