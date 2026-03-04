using AriaWebAPI.AriaAccessAPI.Core;
using System;

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
            if (string.IsNullOrWhiteSpace(doctorid))
                throw new ArgumentNullException(nameof(doctorid), "doctorid must not be null or empty.");
            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentNullException(nameof(lastname), "lastname must not be null or empty.");
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
