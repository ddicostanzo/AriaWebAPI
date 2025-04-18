using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to create a new patient diagnosis in the Aria Access API.
    /// </summary>
    public class CreatePatientDiagnosisRequest : Diagnosis
    {
        public override JsonString AreaName { get; set; } = new JsonString("AWC:CreatePatientDiagnosis");

        public CreatePatientDiagnosisRequest(string clinicaldesc, string dxcode, int dx_scheme, string patientid):
            base("CreatePatientDiagnosisRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            ClinicalDescription = new JsonString(clinicaldesc);
            DiagnosisCode = new JsonString(dxcode);
            DiagnosisScheme = new JsonInt(dx_scheme);
            PatientId = new JsonString(patientid);

        }

    }
}
