using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// This class is used to represent a patient response in the Aria Access API response.
    /// </summary>
    public class PatientResponse : Patient
    {
        public PatientResponse() : base("Patient:http://services.varian.com/AriaWebConnect/Link") { }
    }
}
