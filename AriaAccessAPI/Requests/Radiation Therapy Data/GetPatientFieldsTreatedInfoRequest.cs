using AriaWebAPI.AriaAccessAPI.Core;
using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to create a request for the GetPatientFieldsTreatedInfo API endpoint.
    /// </summary>
    public class GetPatientFieldsTreatedInfoRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString CourseId { get; set; }
        public JsonDttm TreatmentStartDate { get; set; }
        public JsonDttm TreatmentEndDate { get; set; }

        public GetPatientFieldsTreatedInfoRequest(string mrn, string courseid, DateTime start, DateTime end) :
            base("GetPatientFieldsTreatedInfoRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            if (string.IsNullOrWhiteSpace(courseid))
                throw new ArgumentNullException(nameof(courseid), "courseid must not be null or empty.");
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            TreatmentStartDate = new JsonDttm(start, true);
            TreatmentEndDate = new JsonDttm(end, true);
        }
    }
}
