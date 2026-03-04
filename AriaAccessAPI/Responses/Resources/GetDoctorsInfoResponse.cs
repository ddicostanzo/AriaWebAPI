using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// Represents a response containing information about doctors.
    /// </summary>
    public class GetDoctorsInfoResponse : AriaAccessObject
    {
        public GetDoctorsInfoResponse() : base("GetDoctorsInfoResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public DoctorResponse[] DoctorsInfo { get; set; }
    }
}
