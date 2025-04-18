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
    /// This class is used to represent the response from the GetPatientPlans API call in the Aria Access API JSON format.
    /// </summary>
    public class GetPatientPlansResponse : AriaAccessObject
    {
        public GetPatientPlansResponse() : base("GetPatientPlansResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public PatientPlan[] PatientPlans { get; set; }
    }
}
