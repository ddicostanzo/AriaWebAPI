using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    /// <summary>
    /// Get Doctors Info Request
    /// Neither parameter of DoctorId or DepartmentID is mandatory 
    /// </summary>
    public class GetDoctorsInfoRequest : AriaAccessObject
    {
        /// <summary>
        /// Doctor Numerical Id. FYI: There is a typo in the documentation, this property must be Id not ID
        /// </summary>
        public JsonString DoctorId { get; set; }
        /// <summary>
        /// Department Id: James Rad Onc or SSCBC Rad Onc
        /// </summary>
        public JsonString DepartmentID { get; set; }
        /// <summary>
        /// Constructor for Get Doctors Info Request
        /// </summary>
        /// <param name="doctorid">Can be null or be the numerical ID of a doctor</param>
        /// <param name="departmentid">The Department ID to search for physicians. Uses the DepartmentId enum to help parse.</param>
        public GetDoctorsInfoRequest(string doctorid, DepartmentId departmentid) : 
            base("GetDoctorsInfoRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if (!string.IsNullOrEmpty(doctorid))
                DoctorId = new JsonString(doctorid);

            if (departmentid != DepartmentId.Null)
            {
                string dept = (departmentid == DepartmentId.JamesRadOnc) ? "James Rad Onc" : "SSCBC Rad Onc";
                DepartmentID = new JsonString(dept);
            }
        }


    }
}
