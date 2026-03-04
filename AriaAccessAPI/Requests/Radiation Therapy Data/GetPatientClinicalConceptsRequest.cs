using AriaWebAPI.AriaAccessAPI.Core;
using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to get patient clinical concepts in the Aria Access API.
    /// </summary>
    public class GetPatientClinicalConceptsRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString CourseId { get; set; }
        public JsonString PrescriptionId { get; set; }

        public GetPatientClinicalConceptsRequest(string mrn, string courseid) :
            base ("GetPatientClinicalConceptsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            if (string.IsNullOrWhiteSpace(courseid))
                throw new ArgumentNullException(nameof(courseid), "courseid must not be null or empty.");
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
        }
        public GetPatientClinicalConceptsRequest(string mrn, string courseid, string rxid) :
            base("GetPatientClinicalConceptsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            if (string.IsNullOrWhiteSpace(courseid))
                throw new ArgumentNullException(nameof(courseid), "courseid must not be null or empty.");
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            PrescriptionId = new JsonString(rxid);
        }
    }
}
