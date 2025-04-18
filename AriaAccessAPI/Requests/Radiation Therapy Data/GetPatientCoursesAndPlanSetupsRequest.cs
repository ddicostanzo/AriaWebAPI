using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class represents a request to get patient courses and plan setups from the Aria Access API.
    /// </summary>
    public class GetPatientCoursesAndPlanSetupsRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString TreatmentType { get; set; }

        public GetPatientCoursesAndPlanSetupsRequest(string mrn, TreatmentType treatmenttype) :
            base("GetPatientCoursesAndPlanSetupsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            PatientId = new JsonString(mrn);
            TreatmentType = new JsonString(treatmenttype.ToString());
        }
    }
}
