using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// The CancerStage class represents a cancer stage object in the Aria Access API.
    /// </summary>
    public class CancerStage : AriaAccessObject
    {
        public CancerStage() : base("CancerStage:http://services.varian.com/AriaWebConnect/Link") { }
        
        public JsonString BasisCode { get; set; }
        public JsonString CancerStageCode { get; set; }
        public JsonInt CancerStageId { get; set; }
        public JsonDttm DateStaged { get; set; }
        public JsonString ErrorReasonDescription { get; set; }
        public JsonBool IsApproved { get; set; }
        public JsonBool IsValidEntry { get; set; }
        public JsonBool IsWorkingStage { get; set; }
        public JsonInt SchemeId { get; set; }
        public JsonInt StageTimingId { get; set; }
        public StagingCriteria[] StagingCriteria { get; set; }
    }
}
