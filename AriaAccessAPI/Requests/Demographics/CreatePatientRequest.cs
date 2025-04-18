//using OSU_HL7.HL7.Core;
//using OSU_HL7.HL7.DataTypes;
using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                    , string hostpitalname, System.DateTime birthdate, string sex, string race, bool inpatientflag = false):
            base("CreatePatientRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            LastName.Value = lastname;
            FirstName.Value = firstname;
            PatientId1.Value = patientid;
            DepartmentId.Value = departmentid;
            HospitalName.Value = hostpitalname;
            BirthDate = new JsonDttm(birthdate);
            Sex.Value = sex;
            Race.Value = race;
            IsInPatient.Value = inpatientflag;
            AreaName = new JsonString("AWC:CreatePatient");
        }

        //public CreatePatientRequest(Message msg) :
        //    base("CreatePatientRequest:http://services.varian.com/AriaWebConnect/Link")
        //{
        //    var PIDseg = msg.Segments.First(a => a.SegmentID == "PID");

        //    var PatientIdField = (ExtendedCompositeIDWithCheckDigit)PIDseg.Fields.First(a => a.Sequence == 3);
        //    var mrn = PatientIdField.IdNumber;
        //    var PatientNameField = (ExtendedPersonName)PIDseg.Fields.First(a => a.Sequence == 5);
        //    var lastname = PatientNameField.LastName;
        //    var firstname = PatientNameField.FirstName;
        //    var middlename = PatientNameField.MiddleNameOrInitial;
        //    var suffix = (string.IsNullOrEmpty(PatientNameField.Suffix)) ? string.Empty : PatientNameField.Suffix;

        //}
    }
}
