using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;
using AriaWebAPI.Helpers;
using System;
using System.Text.Json.Serialization;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class represents a request to get machine appointments in the Aria Access API.
    /// </summary>
    public class GetMachineAppointmentRequest : AriaAccessObject
    {
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonString DepartmentName { get; set; }
        public JsonDttm StartDateTime { get; set; }
        public JsonString HospitalName { get; set; }
        public JsonString MachineId { get; set; }
        public JsonString ResourceType { get; set; }
        public JsonDttm EndDateTime { get; set; }

        /// <summary>
        /// The constructor for the GetMachineAppointmentRequest class. All parameters are required.
        /// </summary>
        /// <param name="dept">Enumerated Department Id</param>
        /// <param name="start">Start DateTime</param>
        /// <param name="end">End DateTime</param>
        /// <param name="hospital">Enumerated Hospital Id</param>
        /// <param name="machineid">Enumerated Machine Id</param>
        /// <param name="type">Enumerated Resource Type</param>
        public GetMachineAppointmentRequest(DepartmentId dept, DateTime start, DateTime end, HospitalId hospital, MachineId machineid, ResourceType type)
            : base("GetMachineAppointmentsRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            DepartmentName = new JsonString(DeptAndHospitalEnumParser.DepartmentfromEnum[dept]);
            StartDateTime = new JsonDttm(start);
            HospitalName = new JsonString(DeptAndHospitalEnumParser.HospitalfromEnum[hospital]);
            MachineId = new JsonString(machineid.ToString());
            EndDateTime = new JsonDttm(end);
            ResourceType = new JsonString(type.ToString());
        }
    }
}
