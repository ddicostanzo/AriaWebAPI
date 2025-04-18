using AriaWebAPI.AriaAccessAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.DataTypes
{
    /// <summary>
    /// This class represents a machine in the Aria Access API.
    /// </summary>
    public class Machine : AriaAccessObject
    {
        public Machine() : base("Machine:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString MachineId { get; set; }
        public JsonString MachineType { get; set; }
    }
}
