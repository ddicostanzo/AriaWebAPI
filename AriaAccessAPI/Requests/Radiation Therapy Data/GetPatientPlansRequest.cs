using AriaWebAPI.AriaAccessAPI.Core;
using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to get patient plans in the Aria Access API.
    /// </summary>
    public class GetPatientPlansRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString CourseId { get; set; }
        public JsonString PlanSetupId { get; set; }

        public GetPatientPlansRequest(string mrn, string courseid) :
            base("GetPatientPlansRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            if (string.IsNullOrWhiteSpace(courseid))
                throw new ArgumentNullException(nameof(courseid), "courseid must not be null or empty.");
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
        }
        public GetPatientPlansRequest(string mrn, string courseid, string planid) :
            base("GetPatientPlansRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            if (string.IsNullOrWhiteSpace(courseid))
                throw new ArgumentNullException(nameof(courseid), "courseid must not be null or empty.");
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            PlanSetupId = new JsonString(planid);
        }
    }
}
