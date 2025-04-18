using AriaWebAPI.AriaAccessAPI.Core;

namespace AriaWebAPI.AriaAccessAPI.Responses
{
    /// <summary>
    /// This class is used to represent the response from the GetMachineAppointment API call.
    /// </summary>
    public class GetMachineAppointmentResponse : AriaAccessObject
    {
        public GetMachineAppointmentResponse() : base("GetMachineAppointmentResponse:http://services.varian.com/AriaWebConnect/Link") { }
        public JsonString[] Attributes { get; set; }
        public MachineAppointment[] MachineAppointments { get; set; }
    }

}
