using AriaWebAPI.AriaAccessAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// The MachineAppointment Aria Access Object.
    /// </summary>
    public class MachineAppointment : AriaAccessObject
    {
        public MachineAppointment() : base("MachineAppointment:http://services.varian.com/AriaWebConnect/Link") { }
        public MachineAppointment(string type) : base(type) { }
        public JsonString ActivityName { get; set; }
        public JsonString ActivityNote { get; set; }
        public JsonString ActivityStatus { get; set; }
        public AssociatedResource[] AssociatedResources { get; set; }
        public JsonString DepartmentName { get; set; }
        public JsonString HospitalName { get; set; }
        public JsonBool IsExclusive { get; set; }
        public JsonBool IsPrimary { get; set; }
        public JsonString MachineId { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString ResourceType { get; set; }
        public JsonDttm ScheduledEndTime { get; set; }
        public JsonDttm ScheduledStartTime { get; set; }
        public JsonDttm TimeStamp { get; set; }
        public JsonString UID { get; set; }
    }

}
