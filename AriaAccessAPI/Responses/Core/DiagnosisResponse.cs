using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// The DiagnosisResponse class represents a response object for a diagnosis in the Aria Access API.
    /// </summary>
    public class DiagnosisResponse : Diagnosis
    {
        public DiagnosisResponse() : base("Diagnosis:http://services.varian.com/AriaWebConnect/Link") { }
        public override JsonString AreaName { get; set; }
    }
}
