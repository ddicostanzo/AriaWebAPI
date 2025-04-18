using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// This class represents a request to create a machine appointment in the Aria Access API.
    /// </summary>
    public class CreateMachineAppointmentRequest : MachineAppointment
    {
        public JsonString AreaName { get; set; } = new JsonString("AWC:CreateMachineAppointment");
       
        public CreateMachineAppointmentRequest(string activityname, string department, string hospital, DateTime start, DateTime end, string patientid, string machineid) :
            base ("CreateMachineAppointmentRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            ActivityName = new JsonString(activityname);
            DepartmentName = new JsonString(department);
            HospitalName = new JsonString(hospital);
            ScheduledStartTime = new JsonDttm(start);
            ScheduledEndTime = new JsonDttm(end);
            PatientId = new JsonString(patientid);
            MachineId = new JsonString(machineid);
        }
        public CreateMachineAppointmentRequest(string activityname, string department, string hospital, DateTime start, DateTime end, string patientid, string machineid, AssociatedResource[] resources) :
           base("CreateMachineAppointmentRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            ActivityName = new JsonString(activityname);
            DepartmentName = new JsonString(department);
            HospitalName = new JsonString(hospital);
            ScheduledStartTime = new JsonDttm(start);
            ScheduledEndTime = new JsonDttm(end);
            PatientId = new JsonString(patientid);
            MachineId = new JsonString(machineid);
            AssociatedResources = resources;
        }
        public CreateMachineAppointmentRequest(string activityname, string activitynote, string department, string hospital, DateTime start, DateTime end, string patientid, string machineid) :
            base("CreateMachineAppointmentRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            ActivityName = new JsonString(activityname);
            DepartmentName = new JsonString(department);
            HospitalName = new JsonString(hospital);
            ScheduledStartTime = new JsonDttm(start);
            ScheduledEndTime = new JsonDttm(end);
            PatientId = new JsonString(patientid);
            MachineId = new JsonString(machineid);
            ActivityNote = new JsonString(activitynote);
        }
        public CreateMachineAppointmentRequest(string activityname, string activitynote, string department, string hospital, DateTime start, DateTime end, string patientid, string machineid, AssociatedResource[] resources) :
            base("CreateMachineAppointmentRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            ActivityName = new JsonString(activityname);
            DepartmentName = new JsonString(department);
            HospitalName = new JsonString(hospital);
            ScheduledStartTime = new JsonDttm(start);
            ScheduledEndTime = new JsonDttm(end);
            PatientId = new JsonString(patientid);
            MachineId = new JsonString(machineid);
            ActivityNote = new JsonString(activitynote);
            AssociatedResources = resources;
        }
    }
}
