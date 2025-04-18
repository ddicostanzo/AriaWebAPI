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
    /// The GetPatientPlanTxFieldsResponse class represents the response from the GetPatientPlanTxFields API call.
    /// </summary>
    public class GetPatientPlanTxFieldsResponse : AriaAccessObject
    {
        public GetPatientPlanTxFieldsResponse() : base("GetPatientPlansResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public FieldInfo[] FieldInfos { get; set; }
    }
}
