using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to assign a doctor to a patient in the Aria Access API.
    /// </summary>
    public class AssignDoctorToPatientRequest : AriaAccessObject
    {
        public JsonString AreaName { get; set; } = new JsonString("AWC:AssignDoctorToPatient");
        public JsonString Comment { get; set; } = new JsonString();
        public JsonString DoctorId { get; set; } = new JsonString(16);
        public JsonString PatientID { get; set; } = new JsonString(25);
        public JsonBool IsOncologist { get; set; } = new JsonBool(true);
        public JsonBool IsPrimary { get; set; } = new JsonBool(true);

        public AssignDoctorToPatientRequest(string comment, string doctorid, string patientid, bool isoncologist, bool isprimary) :
            base("AssignDoctorToPatientRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            Comment.Value = comment;
            DoctorId.Value = doctorid;
            PatientID.Value = patientid;
            IsOncologist.Value = isoncologist;
            IsPrimary.Value = isprimary;
        }
        public AssignDoctorToPatientRequest(string comment, string doctorid, string patientid, bool isoncologist, bool isprimary, string type) :
           base(type)
        {
            Comment.Value = comment;
            DoctorId.Value = doctorid;
            PatientID.Value = patientid;
            IsOncologist.Value = isoncologist;
            IsPrimary.Value = isprimary;
        }

    }
}
