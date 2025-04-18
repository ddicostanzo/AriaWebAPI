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
    /// Update Patient Request
    /// Not passing any of the non-mandatory parameters in Update Web Services 
    /// retains the already existing values in ARIA
    /// </summary>
    public class UpdatePatientRequest : Patient
    {

        /// <summary>
        /// Requiring a patient to set the same data first before modifying individual fields
        /// </summary>
        /// <param name="patient">Patient that is attempting to be modified to use as basis for changes</param>
        public UpdatePatientRequest(PatientResponse patient, bool istimestamprequired, DateTime? timestamp) : 
            base("UpdatePatientRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            AddressLine1 = patient.AddressLine1;
            AddressLine2 = patient.AddressLine2;
            AutopsyOutcome = patient.AutopsyOutcome;
            AutopsyStatus = patient.AutopsyStatus;
            AreaName = new JsonString("AWC:UpdatePatient");
            BirthCity = patient.BirthCity;
            BirthCountry = patient.BirthCountry;
            BirthCounty = patient.BirthCounty;
            BirthState = patient.BirthState;
            BirthDate = patient.BirthDate;
            BloodGroup = patient.BloodGroup;
            Citizenship = patient.Citizenship;
            CityOrTownship = patient.CityOrTownship;
            ContrastAllergies = patient.ContrastAllergies;
            Country = patient.Country;
            County = patient.County;
            DeathCause = patient.DeathCause;
            DeathDate = patient.DeathDate;
            DepartmentId = patient.DepartmentId;
            FirstName = patient.FirstName;
            HomePhoneNumber = patient.HomePhoneNumber;
            Honorific = patient.Honorific;
            HospitalName = patient.HospitalName;
            InEndDate = patient.InEndDate;
            InProjectedEndDate = patient.InProjectedEndDate;
            InStartDate = patient.InStartDate;
            IsInPatient = patient.IsInPatient;
            LastMenstrualDate = patient.LastMenstrualDate;
            LastName = patient.LastName;
            MaidenName = patient.MaidenName;
            MaritalStatus = patient.MaritalStatus;
            MedRecordsLocator = patient.MedRecordsLocator;
            MedicalAlerts = patient.MedicalAlerts;
            MiddleName = patient.MiddleName;
            MothersMaidenName = patient.MothersMaidenName;
            NameSuffix = patient.NameSuffix;
            NewPatientId1 = patient.NewPatientId1;
            Occupation = patient.Occupation;
            PassportNumber = patient.PassportNumber;
            PatientId1 = patient.PatientId1;
            PatientId2 = patient.PatientId2;
            PatientLocation = patient.PatientLocation;
            PatientState = patient.PatientState;
            PatientStatus = patient.PatientStatus;
            PostalCode = patient.PostalCode;
            PregnancyStatus = patient.PregnancyStatus;
            Race = patient.Race;
            Religion = patient.Religion;
            RetirementDate = patient.RetirementDate;
            RetirementNote = patient.RetirementNote;
            RetirementReason = patient.RetirementReason;
            StateOrProvince = patient.StateOrProvince;
            Sex = patient.Sex;
            SmokingStatus = patient.SmokingStatus;
            SSN = patient.SSN;
            TransportName = patient.TransportName;
            TransportPhoneNumber = patient.TransportPhoneNumber;
            UniversalPatientId = patient.UniversalPatientId;
            WorkPhoneNumber = patient.WorkPhoneNumber;
            UserDefinedAttributes = patient.UserDefinedAttributes;
            PatientNames = patient.PatientNames;

            IsTimeStampCheckRequired = new JsonBool(istimestamprequired);

            if (istimestamprequired && timestamp.HasValue)
                TimeStamp = new JsonDttm(timestamp.Value);
            if (istimestamprequired && !timestamp.HasValue)
                throw new ArgumentException("If IsTimeStamp is set to True then a TimeStamp is required");
            if (!istimestamprequired && timestamp.HasValue)
                throw new ArgumentException("If IsTimeStamp is set to False then timestamp must be null");
        }
    }
}
