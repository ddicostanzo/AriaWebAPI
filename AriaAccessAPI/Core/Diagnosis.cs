using AriaWebAPI.AriaAccessAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// The Dianosis class representing a diagnosis object in the Aria Access API.
    /// </summary>
    public abstract class Diagnosis : AriaAccessObject
    {
        public Diagnosis() : base("Diagnosis:http://services.varian.com/AriaWebConnect/Link") { }
        public Diagnosis(string type) : base(type) { }
        public abstract JsonString AreaName { get; set; }
        public JsonString BehaviorCode { get; set; }
        public JsonString ClinicalDescription { get; set; } = new JsonString();
        public JsonDttm DiagnosisDate { get; set; }
        public JsonString DiagnosisDetails { get; set; }
        public JsonInt DiagnosisMethodId { get; set; }
        public JsonString DiagnosisMethodDescription { get; set; }
        public JsonInt DiagnosisSiteId { get; set; }
        public JsonString ErrorReasonDescription { get; set; }
        public JsonDttm EvolvedDate { get; set; }
        public JsonInt EvolvedFromPatientDiagnosisId { get; set; }
        public JsonString DiagnosisCode { get; set; } = new JsonString();
        public JsonString DiagnosisCodeDescription { get; set; }
        public JsonInt DiagnosisScheme { get; set; } = new JsonInt();
        public JsonBool IsAdverseEvent { get; set; }
        public JsonBool IsConfirmed { get; set; }
        public JsonBool IsFromExternalSource { get; set; }
        public JsonBool IsHistoric { get; set; }
        public JsonBool IsICDCodeReported { get; set; }
        public JsonBool IsMetastasized { get; set; }
        public JsonBool IsValidEntry { get; set; }
        public JsonInt PatientDiagnosisId { get; set; }
        public JsonString PatientId { get; set; } = new JsonString(25);
        public JsonInt PrimaryCancerSiteId { get; set; }
        public JsonInt PrimaryPatientDiagnosisId { get; set; }
        public JsonString Ranking { get; set; }
        public JsonDttm DiagnosisStatusDate { get; set; }
        public JsonInt DiagnosisStatusId { get; set; }
        public CancerStage[] Stage { get; set; }
    }
}
