using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// Represents a response containing information about a doctor.
    /// </summary>
    public class DoctorResponse : Doctor
    {
        public DoctorResponse() : base("Doctor:http://services.varian.com/AriaWebConnect/Link") { }

    }
}
