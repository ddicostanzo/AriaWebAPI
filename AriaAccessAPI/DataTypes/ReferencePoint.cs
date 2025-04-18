using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class represents a reference point in the Aria Access API. 
    /// </summary>
    public class ReferencePoint : AriaAccessObject
    {
        public ReferencePoint() : base("ReferencePoint:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonFloat DailyDoseLimit { get; set; }
        public JsonString PatientId { get; set; }
        public JsonString PatientVolumeId { get; set; }
        public JsonString ReferencePointId { get; set; }
        public JsonString ReferencePointName { get; set; }
        public JsonString ReferencePointType { get; set; }
        public JsonFloat SessionDoseLimit { get; set; }
        public JsonFloat TotalDoseLimit { get; set; }
    }
}
