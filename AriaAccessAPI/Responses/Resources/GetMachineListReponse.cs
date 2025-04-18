using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.DataTypes;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// This class represents the response from the GetMachineList API call.
    /// </summary>
    public class GetMachineListReponse : AriaAccessObject
    {
        public GetMachineListReponse() : base("GetMachineListReponse:http://services.varian.com/AriaWebConnect/Link") { }
        public AriaAccessAttribute[] Attributes { get; set; }
        public Machine[] Machines { get; set; }
    }
}
