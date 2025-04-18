using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class represents a request to update a patient's diagnosis in the Aria Access API.
    /// </summary>
    public class UpdatePatientDiagnosisRequest : Diagnosis
    {
        public override JsonString AreaName { get; set; } = new JsonString("AWC:UpdatePatientDiagnosis");
        
        /// <summary>
        /// Constructor for the Update Patient Diagnosis Request. Takes a DiagnosisResponse to ensure 
        /// consistent and manual editing. Each field must be modified individually.
        /// </summary>
        /// <param name="response">Basis for the update.</param>
        public UpdatePatientDiagnosisRequest(DiagnosisResponse response) : 
            base("UpdatePatientDiagnosisRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            AreaName = response.AreaName;
            BehaviorCode = response.BehaviorCode;
            ClinicalDescription = response.ClinicalDescription;
            DiagnosisDate = response.DiagnosisDate;
            DiagnosisDetails = response.DiagnosisDetails;
            DiagnosisMethodId = response.DiagnosisMethodId;
            DiagnosisMethodDescription = response.DiagnosisMethodDescription;
            DiagnosisSiteId = response.DiagnosisSiteId;
            ErrorReasonDescription = response.ErrorReasonDescription;
            EvolvedDate = response.EvolvedDate;
            EvolvedFromPatientDiagnosisId = response.EvolvedFromPatientDiagnosisId;
            DiagnosisCode = response.DiagnosisCode;
            DiagnosisCodeDescription = response.DiagnosisCodeDescription;
            DiagnosisScheme = response.DiagnosisScheme;
            IsAdverseEvent = response.IsAdverseEvent;
            IsConfirmed = response.IsConfirmed;
            IsFromExternalSource = response.IsFromExternalSource;
            IsHistoric = response.IsHistoric;
            IsICDCodeReported = response.IsICDCodeReported;
            IsMetastasized = response.IsMetastasized;
            IsValidEntry = response.IsValidEntry;
            PatientDiagnosisId = response.PatientDiagnosisId;
            PatientId = response.PatientId;
            PrimaryCancerSiteId = response.PrimaryCancerSiteId;
            PrimaryPatientDiagnosisId = response.PrimaryPatientDiagnosisId;
            Ranking = response.Ranking;
            DiagnosisStatusDate = response.DiagnosisStatusDate;
            DiagnosisStatusId = response.DiagnosisStatusId;
            Stage = response.Stage;

        }
    }
}
