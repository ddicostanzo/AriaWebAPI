using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class represents the PatientPlanSetup object in the Aria Access API. It is the base for the PlanSetup class.
    /// </summary>
    public class PatientPlanSetup : AriaAccessObject
    {
        public PatientPlanSetup() : base("PatientPlanSetup:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString ApprovalStatus { get; set; }
        public JsonString ApprovedBy { get; set; }
        public JsonDttm ApprovedDateTime { get; set; }
        public JsonString TreatmentType { get; set; }
    }
}
