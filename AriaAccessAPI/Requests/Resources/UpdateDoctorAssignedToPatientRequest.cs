using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class is used to represent a request to update the assignment of a doctor to a patient in the Aria Access API.
    /// </summary>
    public class UpdateDoctorAssignedToPatientRequest : AssignDoctorToPatientRequest
    {
        public JsonBool IsTimeStampCheckRequired { get; set; } = new JsonBool(false);
        public JsonDttm TimeStamp { get; set; }

        /// <summary>
        /// The constructor for the UpdateDoctorAssignedToPatientRequest class.
        /// </summary>
        /// <param name="comment">Comment to include</param>
        /// <param name="doctorid">The doctor ID</param>
        /// <param name="patientid">The patient MRN</param>
        /// <param name="isoncologist">Flag for if the doctor is the oncologist</param>
        /// <param name="isprimary">Flag for if the doctor is primary</param>
        /// <param name="istimestamprequired">Optional. Timestamp is required if timestamp flag is true.</param>
        /// <param name="timestamp">Optional. The length of time for the physician to be assigned.</param>
        /// <exception cref="ArgumentException"></exception>
        public UpdateDoctorAssignedToPatientRequest(string comment, string doctorid, string patientid, bool isoncologist
                                                    , bool isprimary, bool istimestamprequired = false, DateTime? timestamp = null) 
                                                    : base(comment, doctorid, patientid, isoncologist, isprimary, 
                                                          "UpdateDoctorAssignedToPatientRequest:http://services.varian.com/AriaWebConnect/Link") 
        {
            AreaName.Value = "AWC:UpdateDoctorToPatient";
            Comment.Value = comment;
            DoctorId.Value = doctorid;
            PatientID.Value = patientid;
            IsOncologist.Value = isoncologist;
            IsPrimary.Value = isprimary;

            IsTimeStampCheckRequired.Value = istimestamprequired;

            if (istimestamprequired && timestamp.HasValue)
                TimeStamp = new JsonDttm(timestamp.Value);
            if (istimestamprequired && !timestamp.HasValue)
                throw new ArgumentException("If IsTimeStamp is set to True then a TimeStamp is required");
            if (!istimestamprequired && timestamp.HasValue)
                throw new ArgumentException("If IsTimeStamp is set to False then timestamp must be null");

        }

    }
}
