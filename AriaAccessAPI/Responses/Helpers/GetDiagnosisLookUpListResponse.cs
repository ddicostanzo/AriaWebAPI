using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.DataTypes;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// This class is used to represent the response from the GetDiagnosisLookUpList method in the Aria Access API.
    /// </summary>
    public class GetDiagnosisLookUpListResponse : AriaAccessObject
    {
        public GetDiagnosisLookUpListResponse() : base("DiagnosisLookUpItem:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public DiagnosisLookUpItem[] LookUpList { get; set; }
    }
}
