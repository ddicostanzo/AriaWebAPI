using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// The GetPatientClinicalConceptsResponse class represents the response from the GetPatientClinicalConcepts API call.
    /// </summary>
    public class GetPatientClinicalConceptsResponse : AriaAccessObject
    {
        public GetPatientClinicalConceptsResponse() : base("GetPatientClinicalConceptsResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public PatientClinicalConcept[] PatientClinicalConcepts { get; set; }
    }
}