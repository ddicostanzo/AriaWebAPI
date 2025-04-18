# AriaWebAPI

This library compiles to a DLL that should be used in conjunction with other solutions or projects. The simple interface leverages the classes that were constructed from the Aria Access API JSON requests and responses. The simple interface is as follows.

1. Setup a .env file in the root directory that contains the following information:
    GatewayRestUrl=https://<i>your VSP server</i>:55051/Gateway/service.svc/interop/rest/process
    aria_access_api_key=<i>your API key for Aria Access</i>
    doc_api_key=<i>your API key for Documents access</i>
2. The Enums.HospitalIdEnum, Enums.DepartmentIdEnum, Enums.MachineIdEnum, and Helpers.DeptAndHospitalEnumParser must be configured for your Aria environment.
3. Create your project and reference the DLL or project.
4. Access the information like so:
```
using AriaWebAPI.AriaAccessAPI.Requests;
using AriaWebAPI.AriaAccessAPI.Responses;
using AriaWebAPI.AriaAccessAPI.Enums;
using AriaWebAPI.AriaAccessAPI.Communication;
using System.Text.Json;

EnvReader.Load(".env");
string? apiKey = Environment.GetEnvironmentVariable("aria_access_api_key");
string? GatewayRestUrl = Environment.GetEnvironmentVariable("GatewayRestUrl");

if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(GatewayRestUrl))
{
    Console.WriteLine("API key or Gateway URL is not set in the environment variables.");
    return;
}

var request = JsonSerializer.Serialize(new GetMachineAppointmentRequest(DepartmentId.JOC_Protons,
                                                                           new DateTime(2025, 01, 01),
                                                                           new DateTime(2025, 01, 05),
                                                                           HospitalId.JOC,
                                                                           MachineId.PB360_TR1,
                                                                           ResourceType.Machine)
                                                                           ); // Serialize the object
var response = Communication.SendData(request, true, apiKey, GatewayRestUrl);
var result = JsonSerializer.Deserialize<GetMachineAppointmentResponse>(response); // Deserialize the response

Console.WriteLine(result);
```
