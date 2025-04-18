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
    /// This class represents the response from the GetPatientPlanSetups API call.
    /// </summary>
    public class GetPatientPlanSetupsResponse : AriaAccessObject
    {
        public GetPatientPlanSetupsResponse() : base("GetPatientPlanSetupsResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public PlanSetup[] PlanSetups { get; set; }

    }
}
