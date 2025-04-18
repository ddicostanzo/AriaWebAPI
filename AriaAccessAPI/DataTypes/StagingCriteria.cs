using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class is used to represent the StagingCriteria object in the Aria Access API.
    /// </summary>
    public class StagingCriteria : AriaAccessObject
    {
        public StagingCriteria() : base("StagingCriteria:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString CriteriaCode { get; set; }
        public JsonString HeaderCode { get; set; }
        public JsonBool IsValidEntry { get; set; }

    }
}
