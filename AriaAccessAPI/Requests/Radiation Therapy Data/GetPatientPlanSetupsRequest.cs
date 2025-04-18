using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// The GetPatientPlanSetupsRequest class is used to request plan setups for a specific patient and course in the Aria Access API.
    /// </summary>
    public class GetPatientPlanSetupsRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString CourseId { get; set; }
        public JsonString PlanSetupId { get; set; }

        public GetPatientPlanSetupsRequest(string mrn, string courseid) :
            base("GetPatientPlanSetupsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
        }
        public GetPatientPlanSetupsRequest(string mrn, string courseid, string planid) :
            base("GetPatientPlanSetupsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            PlanSetupId = new JsonString(planid);
        }
    }
}
