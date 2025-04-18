using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class is used to represent the TreatedField object in the Aria Access API.
    ///</summary>
    public class TreatedField : AriaAccessObject
    {
        public TreatedField() : base("TreatedFieldInfo:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public JsonInt ActualDailyDose { get; set; }
        public JsonInt CollMode { get; set; }
        public JsonFloat CollRotation { get; set; }
        public JsonFloat CollX1 { get; set; }
        public JsonFloat CollX2 { get; set; }
        public JsonFloat CollY1 { get; set; }
        public JsonFloat CollY2 { get; set; }
        public JsonFloat CouchLatitude { get; set; }
        public JsonFloat CouchLongitude { get; set; }
        public JsonFloat CouchRotation { get; set; }
        public JsonFloat CouchVertical { get; set; }
        public JsonString CourseId { get; set; }
        public JsonInt ElapseDays { get; set; }
        public JsonString EnergyMode { get; set; }
        public JsonString FieldId { get; set; }
        public JsonString FieldName { get; set; }
        public JsonInt FractionNumber { get; set; }
        public JsonString GantryRotation { get; set; }
        public JsonInt MU { get; set; }
        public JsonFloat MUdegree { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString ReferencePointId { get; set; }
        public JsonString ReferencePointName { get; set; }
        public JsonString Scale { get; set; }
        public JsonString StopAngle { get; set; }
        public JsonFloat TSD { get; set; }
        public JsonDttm TreatmentDate { get; set; }
        public JsonFloat TreatmentTime { get; set; }
        public JsonString TreatmentType { get; set; }
        public JsonString TrtmntTypeFlag { get; set; }
    }
}
