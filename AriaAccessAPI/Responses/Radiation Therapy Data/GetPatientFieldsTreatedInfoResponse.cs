using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// This class is used to represent the GetPatientFieldsTreatedInfoResponse object in the Aria Access API.
    /// </summary>
    public class GetPatientFieldsTreatedInfoResponse : AriaAccessObject
    {
        public GetPatientFieldsTreatedInfoResponse() : base("GetPatientFieldsTreatedInfoResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public TreatedField[] TreatedFieldsInfo { get; set; }
        public JsonInt TotalDoseDeliveredToDate { get; set; }

    }
}
