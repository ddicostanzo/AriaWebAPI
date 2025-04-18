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
    /// This class represents the response from the GetPatientRefPoints API call in the Aria Access API.
    /// </summary>
    public class GetPatientRefPointsResponse : AriaAccessObject
    {
        public GetPatientRefPointsResponse() : base("GetPatientRefPointsResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public ReferencePoint[] ReferencePoints { get; set; }
    }
}