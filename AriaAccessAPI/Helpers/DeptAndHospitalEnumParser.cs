using AriaWebAPI.AriaAccessAPI.Enums;
using System;
using System.Collections.Generic;

namespace AriaWebAPI.AriaAccessAPI.Helpers
{
    /// <summary>
    /// The DeptAndHospitalEnumParser class provides a mapping between DepartmentId and HospitalId enums to their string representations.
    /// These should be customized based on the data entered in Data Admin for the Aria system.
    /// </summary>
    public static class DeptAndHospitalEnumParser
    {
        public static readonly IReadOnlyDictionary<DepartmentId, string> DepartmentFromEnum = new Dictionary<DepartmentId, string>()
        {
            { DepartmentId.Null, "" },
            { DepartmentId.JamesRadOnc, "James Rad Onc" },
            { DepartmentId.SSCBCRadOnc, "SSCBC Rad Onc" },
            { DepartmentId.JOC_Photons, "Carmenton Rad Onc" },
            { DepartmentId.JOC_Protons, "Proton Rad Onc" },
        };

        public static readonly IReadOnlyDictionary<HospitalId, string> HospitalFromEnum = new Dictionary<HospitalId, string>()
        {
            { HospitalId.OSUCCCJames, "OSUCCC - James" },
            { HospitalId.SSCBC, "JamesCare Comprehensive Breast Center" },
            { HospitalId.JOC, "The James Outpatient Care" },
        };

        // Kept for backward compatibility
        [Obsolete("Use DepartmentFromEnum")]
        public static IReadOnlyDictionary<DepartmentId, string> DepartmentfromEnum => DepartmentFromEnum;

        // Kept for backward compatibility
        [Obsolete("Use HospitalFromEnum")]
        public static IReadOnlyDictionary<HospitalId, string> HospitalfromEnum => HospitalFromEnum;
    }
}
