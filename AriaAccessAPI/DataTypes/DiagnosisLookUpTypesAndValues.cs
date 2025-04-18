using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    public static class DiagnosisLookUpTypesAndValues
    {
        public static Dictionary<int, DiagnosisLookUpItem> DiagnosisMethod = new Dictionary<int, DiagnosisLookUpItem>()
        {
            { 0, new DiagnosisLookUpItem("Unknown", "ENU", "0") },
            { 1, new DiagnosisLookUpItem("Biopsy", "ENU", "1") },
            { 2, new DiagnosisLookUpItem("Histology/Pathology", "ENU", "2") },
            { 3, new DiagnosisLookUpItem("Cytology", "ENU", "3") },
            { 4, new DiagnosisLookUpItem("Tumor Marker", "ENU", "4") },
            { 5, new DiagnosisLookUpItem("X-ray", "ENU", "5") },
            { 6, new DiagnosisLookUpItem("CT-Scan", "ENU", "6") },
            { 7, new DiagnosisLookUpItem("MRI", "ENU", "7") },
            { 8, new DiagnosisLookUpItem("Ultrasound", "ENU", "8") },
            { 9, new DiagnosisLookUpItem("Clinical", "ENU", "9") },
            { 10, new DiagnosisLookUpItem("Blood Work", "ENU", "10") },
            { 11, new DiagnosisLookUpItem("BM Biopsy", "ENU", "11") },
            { 99, new DiagnosisLookUpItem("Biopsy", "ENU", "99") },
            { 101, new DiagnosisLookUpItem("Direct Visualization", "ENU", "101") },
            { 102, new DiagnosisLookUpItem("Exfoliative Cytology", "ENU", "102") },
            { 103, new DiagnosisLookUpItem("Microscopic Confirmation", "ENU", "103") },
            { 104, new DiagnosisLookUpItem("Extra", "ENU", "104") },
        };

        public static Dictionary<int, DiagnosisLookUpItem> DiagnosisStatus = new Dictionary<int, DiagnosisLookUpItem>()
        {
            { 1, new DiagnosisLookUpItem("Cured", "ENU", "1") },
            { 2, new DiagnosisLookUpItem("Subsided", "ENU", "2") },
            { 3, new DiagnosisLookUpItem("Controlled", "ENU", "3") },
            { 4, new DiagnosisLookUpItem("Ruled Out", "ENU", "4") },
            { 5, new DiagnosisLookUpItem("Other", "ENU", "5") },
            { 6, new DiagnosisLookUpItem("Active", "ENU", "6") },
            { 7, new DiagnosisLookUpItem("Inactive", "ENU", "7") },
            { 8, new DiagnosisLookUpItem("In Remission", "ENU", "8") },
            { 9, new DiagnosisLookUpItem("Resolved", "ENU", "9") },
            { 10, new DiagnosisLookUpItem("Progressed", "ENU", "10") },

        };

        public static Dictionary<int, DiagnosisLookUpItem> DiagnosisScheme = new Dictionary<int, DiagnosisLookUpItem>()
        {
            { 19, new DiagnosisLookUpItem("ICD-9-CM", "ENU", "19") },
            { 20, new DiagnosisLookUpItem("ICD-10", "ENU", "20") },
            { 25, new DiagnosisLookUpItem("ICD-O V3", "ENU", "25") },
            { 30, new DiagnosisLookUpItem("ICD-9", "ENU", "30") },
            { 40, new DiagnosisLookUpItem("CPT", "ENU", "40") },
            { 60, new DiagnosisLookUpItem("ICD-10-CM", "ENU", "60") },
            
        };
    }


}
