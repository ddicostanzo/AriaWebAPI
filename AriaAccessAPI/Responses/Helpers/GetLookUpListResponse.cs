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
    /// This class is used to represent the response from the GetLookUpListRequest in the Aria Access API.
    /// </summary>
    public class GetLookUpListResponse : AriaAccessObject
    {
        public GetLookUpListResponse() : base("LookUpListItem:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public LookUpItem[] LookUpList { get; set; }

    }
}
