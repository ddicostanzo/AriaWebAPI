using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// The DiagnosisResponse class represents a response object for a diagnosis in the Aria Access API.
    /// </summary>
    public class DiagnosisResponse : Diagnosis
    {
        public DiagnosisResponse() : base("Diagnosis:http://services.varian.com/AriaWebConnect/Link") { }
        public override JsonString AreaName { get; set; }
    }
}
