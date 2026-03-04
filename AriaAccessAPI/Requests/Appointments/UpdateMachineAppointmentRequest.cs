using AriaWebAPI.AriaAccessAPI.Core;
using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    public class UpdateMachineAppointmentRequest : MachineAppointment
    {
        public JsonString AreaName { get; set; } = new JsonString("AWC:UpdateMachineAppointment");
        public JsonBool IsTimeStampCheckRequired { get; set; } = new JsonBool(false);
        
        /// <summary>
        /// Constructor for the UpdateMachineAppointment Request. Required to present a previously queried
        /// <c>MachineAppointment</c> as basis for editing. Each field must be edited manually.
        /// </summary>
        /// <param name="response">Previously queried <c>MachineAppointment</c> to allow for editing.</param>
        public UpdateMachineAppointmentRequest(MachineAppointment response, bool istimestamprequired, DateTime? timestamp) :
            base("UpdateMachineAppointmentRequest:http://services.varian.com/AriaWebConnect/Link")

        {
            ActivityName = response.ActivityName;
            ActivityNote = response.ActivityNote;
            ActivityStatus = response.ActivityStatus;
            AssociatedResources = response.AssociatedResources;
            DepartmentName = response.DepartmentName;
            HospitalName = response.HospitalName;
            IsExclusive = response.IsExclusive;
            IsPrimary = response.IsPrimary;
            MachineId = response.MachineId;
            PatientId = response.PatientId;
            ResourceType = response.ResourceType;
            ScheduledEndTime = response.ScheduledEndTime;
            ScheduledStartTime = response.ScheduledStartTime;

            IsTimeStampCheckRequired.Value = istimestamprequired;

            RequestHelpers.ValidateTimestamp(istimestamprequired, timestamp);
            if (istimestamprequired && timestamp.HasValue)
                TimeStamp = new JsonDttm(timestamp.Value);


        }
    }
}
