using AriaWebAPI.AriaAccessAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.Helpers
{
    /// <summary>
    /// The DeptAndHospitalEnumParser class provides a mapping between DepartmentId and HospitalId enums to their string representations.
    /// These should be customized based on the data entered in Data Admin for the Aria system.
    /// </summary>
    public static class DeptAndHospitalEnumParser
    {
        public static Dictionary<DepartmentId, string> DepartmentfromEnum = new Dictionary<DepartmentId, string>() 
        {
            { DepartmentId.JamesRadOnc, "James Rad Onc" },
            { DepartmentId.SSCBCRadOnc, "SSCBC Rad Onc" },
            { DepartmentId.JOC_Photons, "Carmenton Rad Onc" },
            { DepartmentId.JOC_Protons, "Proton Rad Onc" },
        };
        public static Dictionary<HospitalId, string> HospitalfromEnum = new Dictionary<HospitalId, string>()
        {
            { HospitalId.OSUCCCJames, "OSUCCC - James" },
            { HospitalId.SSCBC, "JamesCare Comprehensive Breast Center" },
            { HospitalId.JOC, "The James Outpatient Care" },
        };
    }
}
