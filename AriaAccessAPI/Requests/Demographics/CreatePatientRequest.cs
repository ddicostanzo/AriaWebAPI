using AriaWebAPI.AriaAccessAPI.Core;
using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{

    /// <summary>
    /// Create Patient Request
    /// Mandatory fields include: Last Name, Patient Id, Department Id, Hospital Id, Patient Category, 
    /// Birth Date, Race, Sex 
    /// Race and Sex must conform to pre-configured values in Aria
    /// </summary>
    public class CreatePatientRequest : Patient
    {
        public CreatePatientRequest(string lastname, string firstname, string patientid, string departmentid
                                    , string hospitalname, System.DateTime birthdate, string sex, string race, bool inpatientflag = false):
            base("CreatePatientRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentNullException(nameof(lastname), "lastname must not be null or empty.");
            if (string.IsNullOrWhiteSpace(patientid))
                throw new ArgumentNullException(nameof(patientid), "patientid must not be null or empty.");
            LastName.Value = lastname;
            FirstName.Value = firstname;
            PatientId1.Value = patientid;
            DepartmentId.Value = departmentid;
            HospitalName.Value = hospitalname;
            BirthDate = new JsonDttm(birthdate);
            Sex.Value = sex;
            Race.Value = race;
            IsInPatient.Value = inpatientflag;
            AreaName = new JsonString("AWC:CreatePatient");
        }

    }
}
