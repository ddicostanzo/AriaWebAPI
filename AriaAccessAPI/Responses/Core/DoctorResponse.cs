using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// Represents a response containing information about a doctor.
    /// </summary>
    public class DoctorResponse : Doctor
    {
        public DoctorResponse() : base("Doctor:http://services.varian.com/AriaWebConnect/Link") { }

    }
}
