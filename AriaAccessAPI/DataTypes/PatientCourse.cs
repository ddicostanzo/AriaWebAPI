using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class represents a patient's course in the Aria Access API.
    /// </summary>
    public class PatientCourse : AriaAccessObject
    {
        public PatientCourse() : base("PatientCourses:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString Comment { get; set; }
        public JsonString CompletedBy { get; set; }
        public JsonDttm CompletedDateTime { get; set; }
        public JsonString CourseId { get; set; }
        public JsonString Intent { get; set; }
        public JsonString PatientId { get; set; }
        public PatientPlanSetup[] PatientPlanSetups { get; set; }
        public JsonDttm StartDateTime { get; set; }
    }
}
