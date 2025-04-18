using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// Represents a response containing information about doctors assigned to a patient.
    /// </summary>
    public class GetDoctorsAssignedToPatientResponse : AriaAccessObject
    {
        public GetDoctorsAssignedToPatientResponse() : base("GetDoctorsAssignedToPatientResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        // Returns only a limited view of the doctor, may need to implement
        // a query using GetDoctorsInfo to expand.
        public DoctorResponse[] AssignedDoctors { get; set; }
    }
}
