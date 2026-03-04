using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;
using System;

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
            if (string.IsNullOrWhiteSpace(mrn))
                throw new ArgumentNullException(nameof(mrn), "mrn must not be null or empty.");
            PatientId = new JsonString(mrn);
            TreatmentType = new JsonString(treatmenttype.ToString());
        }
    }
}
