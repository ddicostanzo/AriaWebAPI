using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// Create Doctor Request
    /// Mandatory fields are included in constructor. Other fields are 
    /// accessible manually.
    /// </summary>
    public class CreateDoctorRequest : Doctor
    {
        public CreateDoctorRequest(string displayname, string doctorid, bool isoncologist, string lastname, string firstname, DateTime originationdate, string specialty) :
            base("CreateDoctorRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            DisplayName.Value = displayname;
            DoctorId.Value = doctorid;
            IsOncologist.Value = isoncologist;
            LastName.Value = lastname;
            FirstName.Value = firstname;
            Specialty.Value = specialty;
            OriginationDate = new JsonDttm(originationdate);
        }
    }
}
