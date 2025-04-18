using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Core
{
    /// <summary>
    /// The base class for all Doctor objects in the Aria Access API.
    /// </summary>
    public abstract class Doctor : AriaAccessObject
    {
        public Doctor() : base("Doctor:http://services.varian.com/AriaWebConnect/Link") { }
        public Doctor(string type) : base(type) { }
        public JsonString AddressLine1 { get; set; } = new JsonString();
        public JsonString AddressLine2 { get; set; } = new JsonString();
        public JsonString AddressLine3 { get; set; } = new JsonString();
        public JsonString AreaName { get; set; }
        public JsonString BillingServiceID { get; set; } = new JsonString(16);
        public JsonString CityOrTownship { get; set; } = new JsonString();
        public JsonString Comment { get; set; } = new JsonString();
        public JsonString Country { get; set; } = new JsonString();
        public JsonString County { get; set; } = new JsonString();
        public JsonString DepartmentId { get; set; } = new JsonString();
        public JsonString DisplayName { get; set; } = new JsonString();
        public JsonString DoctorId { get; set; } = new JsonString(16);
        public JsonString EMailAddress { get; set; } = new JsonString();
        public JsonString FaxNumber { get; set; } = new JsonString();
        public JsonString FirstName { get; set; } = new JsonString(64);
        public JsonString Honorific { get; set; } = new JsonString();
        public JsonString Institution { get; set; } = new JsonString();
        public JsonBool IsActive { get; set; } = new JsonBool(true);
        public JsonBool IsOncologist { get; set; } = new JsonBool(true);
        public JsonString LastName { get; set; } = new JsonString();
        public JsonString Location { get; set; } = new JsonString();
        public JsonString MiddleName { get; set; } = new JsonString();
        public JsonString NameSuffix { get; set; } = new JsonString();
        public JsonDttm OriginationDate { get; set; }
        public JsonString PhoneNumber1 { get; set; }
        public JsonString PhoneNumber2 { get; set; }
        public JsonString POCName { get; set; }
        public JsonString PostalCode { get; set; }
        public JsonString Specialty { get; set; }
        public JsonString StateOrProvince { get; set; }
        public JsonDttm TerminationDate { get; set; }



    }
}
