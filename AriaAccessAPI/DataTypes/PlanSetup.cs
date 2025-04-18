using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class represents the PlanSetup object in the Aria Access API.
    /// </summary>
    public class PlanSetup : PatientPlanSetup
    {
        public new string __type { get; set; } = "PlanSetup:http://services.varian.com/AriaWebConnect/Link";
        public JsonInt ApplicationSetupNumber { get; set; }
        public JsonString ApplicationSetupType { get; set; }
        public JsonDttm ApprovalDate { get; set; }
        public JsonString Comment { get; set; }
        public JsonString CourseId { get; set; }
        public JsonString CreatedBy { get; set; }
        public JsonDttm CreationDate { get; set; }
        public JsonString HistoryTaskName { get; set; }
        public JsonString HistoryUserName { get; set; }
        public JsonString PatientId { get; set; }
        public JsonFloat PlanNormFactor { get; set; }
        public JsonString PlanNormMethod { get; set; }
        public JsonString PlanSetupId { get; set; }
        public JsonString PlanSetupName { get; set; }
        public JsonString TreatmentTechnique { get; set; }
    }
}
