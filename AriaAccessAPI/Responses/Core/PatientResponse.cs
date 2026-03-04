using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// This class is used to represent a patient response in the Aria Access API response.
    /// </summary>
    public class PatientResponse : Patient
    {
        public PatientResponse() : base("Patient:http://services.varian.com/AriaWebConnect/Link") { }
    }
}
