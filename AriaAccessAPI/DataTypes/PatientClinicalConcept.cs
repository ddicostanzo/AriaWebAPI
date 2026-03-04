using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// The Patient Clinical Concept Aria Access Object.
    /// </summary>
    public class PatientClinicalConcept : AriaAccessObject
    {
        public PatientClinicalConcept() : base("PatientClinicalConcept:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString BolusFrequency { get; set; }
        public JsonString BolusThickness { get; set; }
        public JsonString CourseId { get; set; }
        public JsonDttm CreationDate { get; set; }
        public JsonString CreationUserName { get; set; }
        public JsonString Energy { get; set; }
        public JsonString Frequency { get; set; }
        public JsonString Gating { get; set; }
        public JsonBool IsPlanLinked { get; set; }
        public JsonString Modality { get; set; }
        public JsonString Notes { get; set; }
        public JsonInt NumberOfFractions { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString PhaseType { get; set; }
        public JsonString Plans { get; set; }
        public JsonString PrescriptionName { get; set; }
        public JsonInt PrescriptionTemplateId { get; set; }
        public PrescriptionVolumeInfo[] PrescriptionVolumeInfo { get; set; }
        public JsonInt SimulationNeeded { get; set; }
        public JsonString Site { get; set; }
        public JsonString Status { get; set; }
        public JsonString Technique { get; set; }
        // NOTE: "TretmentIntentType" is intentionally spelled this way to match the upstream
        // Varian Aria SOAP service field name "TretmentIntentTypeField". Do NOT rename this
        // property, as doing so will break JSON/XML deserialization from the Aria API.
        public JsonString TretmentIntentType { get; set; }
    }
}
