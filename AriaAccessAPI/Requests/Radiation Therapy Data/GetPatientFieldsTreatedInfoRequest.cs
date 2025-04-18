using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            TreatmentStartDate = new JsonDttm(start, true);
            TreatmentEndDate = new JsonDttm(end, true);
        }
    }
}
