using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class is used to represent a patient plan in the Aria Access API JSON format.
    /// </summary>
    public class PatientPlan : PlanSetup
    {
        public new string __type { get; set; } = "PatientPlan:http://services.varian.com/AriaWebConnect/Link";
        public JsonString CreatedByUserName => CreatedBy;
        public JsonString FractionPattern { get; set; }
        public JsonInt NoOfFractions { get; set; }
        public JsonString PlanUID { get; set; }
        public JsonInt StartDelay { get; set; }
    }
}
