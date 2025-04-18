using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to get the doctors assigned to a patient in the Aria Access API.
    /// </summary>
    internal class GetDoctorsAssignedToPatientRequest : AriaAccessObject
    {
        public JsonBool IsOncologist { get; set; } = new JsonBool(true);
        public JsonString PatientId { get; set; } = new JsonString(25);
        /// <summary>
        /// Generates the Get Doctors assigned to patient request. Both parameters are mandatory.
        /// </summary>
        /// <param name="isoncologist">Boolean for is the doctor the oncologist</param>
        /// <param name="patientid">Patient Id to query</param>
        public GetDoctorsAssignedToPatientRequest(bool isoncologist, string patientid) :
            base("GetDoctorsAssignedToPatientRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            IsOncologist.Value = isoncologist;
            PatientId.Value = patientid;
        
        }
    }
}
