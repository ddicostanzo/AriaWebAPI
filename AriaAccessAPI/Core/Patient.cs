using AriaWebAPI.AriaAccessAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// This class is used to represent a patient in the Aria Access API.
    /// </summary>
    public class Patient: AriaAccessObject
    {
        public Patient() : base("Patient:http://services.varian.com/AriaWebConnect/Patient") { }
        public Patient(string type) : base(type) { }

        public JsonString AddressLine1 { get; set; } = new JsonString();
        public JsonString AddressLine2 { get; set; } = new JsonString();
        public JsonString AutopsyOutcome { get; set; } = new JsonString();
        public JsonString AutopsyStatus { get; set; } = new JsonString();
        public JsonString AreaName { get; set; } 
        public JsonString BirthCity { get; set; } = new JsonString();
        public JsonString BirthCountry { get; set; } = new JsonString();
        public JsonString BirthCounty { get; set; } = new JsonString();
        public JsonString BirthState { get; set; } = new JsonString();
        public JsonDttm BirthDate { get; set; }
        public JsonString BloodGroup { get; set; } = new JsonString();
        public JsonString Citizenship { get; set; } = new JsonString();
        public JsonString CityOrTownship { get; set; } = new JsonString();
        public JsonString ContrastAllergies { get; set; } = new JsonString();
        public JsonString Country { get; set; } = new JsonString();
        public JsonString County { get; set; } = new JsonString();
        public JsonString DeathCause { get; set; } = new JsonString();
        public JsonDttm DeathDate { get; set; }
        public JsonString DepartmentId { get; set; } = new JsonString(16);
        public JsonString FirstName { get; set; } = new JsonString(64);
        public JsonString HomePhoneNumber { get; set; } = new JsonString();
        public JsonString Honorific { get; set; } = new JsonString();
        public JsonString HospitalName { get; set; } = new JsonString(64);
        public JsonDttm InEndDate { get; set; }
        public JsonDttm InProjectedEndDate { get; set; }
        public JsonDttm InStartDate { get; set; }
        public JsonBool IsInPatient { get; set; } = new JsonBool(false);
        public JsonBool IsTimeStampCheckRequired { get; set; } = new JsonBool(false);
        public JsonDttm LastMenstrualDate { get; set; }
        public JsonString LastName { get; set; } = new JsonString(64);
        public JsonString MaidenName { get; set; } = new JsonString();
        public JsonString MaritalStatus { get; set; } = new JsonString();
        public JsonString MedRecordsLocator { get; set; } = new JsonString();
        public JsonString MedicalAlerts { get; set; } = new JsonString();
        public JsonString MiddleName { get; set; } = new JsonString();
        public JsonString MothersMaidenName { get; set; } = new JsonString();
        public JsonString NameSuffix { get; set; } = new JsonString();
        public JsonString NewPatientId1 { get; set; } = new JsonString(25);
        public JsonString Occupation { get; set; } = new JsonString();
        public JsonString PassportNumber { get; set; } = new JsonString();
        public JsonString PatientId1 { get; set; } = new JsonString(25);
        public JsonString PatientId2 { get; set; } = new JsonString(string.Empty, 25);
        public JsonString PatientLocation { get; set; }
        public JsonString PatientState { get; set; } = new JsonString();
        public JsonString PatientStatus { get; set; } = new JsonString();
        public JsonString PostalCode { get; set; } = new JsonString(10);
        public JsonString PregnancyStatus { get; set; } = new JsonString();
        public JsonString Race { get; set; } = new JsonString();
        public JsonString Religion { get; set; } = new JsonString();
        public JsonDttm RetirementDate { get; set; }
        public JsonString RetirementNote { get; set; } = new JsonString();
        public JsonString RetirementReason { get; set; } = new JsonString();
        public JsonString StateOrProvince { get; set; } = new JsonString();
        public JsonString Sex { get; set; } = new JsonString();
        public JsonString SmokingStatus { get; set; } = new JsonString();
        public JsonString SSN { get; set; } = new JsonString(9);
        public JsonDttm TimeStamp { get; set; }
        public JsonString TransportName { get; set; } = new JsonString();
        public JsonString TransportPhoneNumber { get; set; } = new JsonString();
        public JsonString UniversalPatientId { get; set; } = new JsonString(32);
        public JsonString WorkPhoneNumber { get; set; } = new JsonString();
        public UserDefinedAttributes UserDefinedAttributes { get; set; } = new UserDefinedAttributes();
        public PatientName[] PatientNames { get; set; }
    }
}
