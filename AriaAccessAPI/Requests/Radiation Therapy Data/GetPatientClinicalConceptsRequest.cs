using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
        }
        public GetPatientClinicalConceptsRequest(string mrn, string courseid, string rxid) :
            base("GetPatientClinicalConceptsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            PatientId = new JsonString(mrn);
            CourseId = new JsonString(courseid);
            PrescriptionId = new JsonString(rxid);
        }
    }
}
