using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// The FieldInfo class represents the information about a treatment field in the Aria Access API.
    /// </summary>
    public class FieldInfo : AriaAccessObject
    {
        public FieldInfo() : base("FieldInfo:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString AddOnId1 { get; set; }
        public JsonString AddOnId2 { get; set; }
        public JsonString AddOnId3 { get; set; }
        public JsonString AddOnId4 { get; set; }
        public JsonString AddOnType1 { get; set; }
        public JsonString AddOnType2 { get; set; }
        public JsonString AddOnType3 { get; set; }
        public JsonString AddOnType4 { get; set; }
        public JsonString CollMode { get; set; }
        public JsonFloat CollRtnM { get; set; }
        public JsonFloat CollX1 { get; set; }
        public JsonFloat CollX2 { get; set; }
        public JsonFloat CollY1 { get; set; }
        public JsonFloat CollY2 { get; set; }
        public JsonFloat CouchLatM { get; set; }
        public JsonFloat CouchLngM { get; set; }
        public JsonFloat CouchRtnM { get; set; }
        public JsonFloat CouchVrtM { get; set; }
        public JsonString CourseId { get; set; }
        public JsonDttm CreationDate { get; set; }
        public JsonInt DoseRate { get; set; }
        public JsonString EnergyMode { get; set; }
        public JsonString FieldId { get; set; }
        public JsonString FieldName { get; set; }
        public JsonString GantryRtnExtended { get; set; }
        public JsonFloat GantryRtnExtension { get; set; }
        public JsonBool IsPartiallyTreated { get; set; }
        public JsonBool IsTreated { get; set; }
        public JsonInt MLCFlag { get; set; }
        public JsonInt MU { get; set; }
        public JsonFloat MWMU { get; set; }
        public JsonString MachineId { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString PlanSetupId { get; set; }
        public JsonFloat SSD { get; set; }
        public JsonString Scale { get; set; }
        public JsonString SetupNote { get; set; }
        public JsonString SlotName1 { get; set; }
        public JsonString SlotName2 { get; set; }
        public JsonString SlotName3 { get; set; }
        public JsonString SlotName4 { get; set; }
        public JsonFloat StopAngleExtension { get; set; }
        public JsonInt TableTopRotation { get; set; }
        public JsonString TechniqueId { get; set; }
        public JsonString ToleranceId { get; set; }
        public JsonString ToleranceTableName { get; set; }
        public JsonFloat TreatmentTime { get; set; }
    }
}
