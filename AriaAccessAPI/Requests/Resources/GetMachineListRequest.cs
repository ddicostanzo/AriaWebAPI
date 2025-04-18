using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    public class GetMachineListRequest : AriaAccessObject
    {
        public JsonString MachineId { get; set; } 
        public JsonString MachineType { get; set; }

        /// <summary>
        /// Generates the Machine List Request Object. Neither parameter is required
        /// </summary>
        /// <param name="machineId">Machine Id to search for in Aria. Can pass null or empty string</param>
        /// <param name="machineType">Machine Type to search for in Aria. Can pass null or empty string</param>
        public GetMachineListRequest(string machineId, MachineType machineType) :
            base("GetMachineListRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            if(!string.IsNullOrEmpty(machineId))
                MachineId = new JsonString(machineId);

            if (machineType != Enums.MachineType.Null)
                MachineType = new JsonString(machineType.ToString());
        }

    }
}
