using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;
using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to get the TxField attributes for a patient plan in the Aria Access API.
    /// </summary>
    public class GetPatientPlanTxFieldsRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString CourseId { get; set; }
        public JsonString PlanId { get; set; }
        public JsonString Scale { get; set; }

        public GetPatientPlanTxFieldsRequest(string mrn, string courseid, string planid) :
            base("GetPatientPlanTxFieldsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            if (string.IsNullOrWhiteSpace(courseid))
                throw new ArgumentNullException(nameof(courseid), "courseid must not be null or empty.");
            if (string.IsNullOrWhiteSpace(planid))
                throw new ArgumentNullException(nameof(planid), "planid must not be null or empty.");
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            PlanId = new JsonString(planid);
        }
        public GetPatientPlanTxFieldsRequest(string mrn, string courseid, string planid, TxFieldScale scale) :
            base("GetPatientPlanTxFieldsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            if (string.IsNullOrWhiteSpace(courseid))
                throw new ArgumentNullException(nameof(courseid), "courseid must not be null or empty.");
            if (string.IsNullOrWhiteSpace(planid))
                throw new ArgumentNullException(nameof(planid), "planid must not be null or empty.");
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            PlanId = new JsonString(planid);
            Scale = new JsonString(scale.ToString());
        }
    }
}
