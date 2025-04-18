using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
        }
        public GetPatientPlansRequest(string mrn, string courseid, string planid) : 
            base("GetPatientPlansRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            PlanSetupId = new JsonString(planid);
        }
    }
}
