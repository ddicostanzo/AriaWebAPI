# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Tooling

Use `grepai` for all codebase and code file searching (not `grep`, `rg`, or the Grep tool).

## What This Project Is

A .NET Framework 4.8 **class library** (DLL) that wraps the Varian Aria radiation therapy system's REST/SOAP gateway. It is not a standalone application — consumers reference the compiled DLL in their own projects. There are no tests in this repository.

## Build

This is a legacy-format `.csproj` targeting .NET Framework 4.8. Build with MSBuild on Windows or via Visual Studio:

```
msbuild AriaWebAPI.sln /p:Configuration=Release
```

Output: `bin\Release\AriaWebAPI.dll`

**Important:** This project uses an explicit `<Compile>` list in `AriaWebAPI.csproj`. Every new `.cs` file you create must be manually added to that list or it will not compile.

## Environment Setup

Copy `.env.template` to `.env` and fill in the three values before running any consuming project:

```
GatewayRestUrl=https://<VSP server>:55051/Gateway/service.svc/interop/rest/process
aria_access_api_key=<Aria Access API key>
doc_api_key=<Documents API key>
```

`EnvReader.Load(".env")` must be called by the consumer before accessing environment variables.

## Architecture

### Request/Response Cycle

1. Consumer serializes a `Request` object: `JsonSerializer.Serialize(new GetMachineAppointmentRequest(...))`
2. Consumer calls `Communication.SendData(json, isJson: true, apiKey, gatewayUrl)`
3. `Communication.SendData` POSTs to the Aria gateway and returns the raw response string
4. Consumer deserializes: `JsonSerializer.Deserialize<GetMachineAppointmentResponse>(response)`

`Communication` uses a shared static `HttpClient` with `UseDefaultCredentials = true` (Windows-integrated auth). `SendData` is synchronous (`.GetAwaiter().GetResult()`).

### Type System: Json* Wrappers

All Aria API fields use wrapper types instead of C# primitives:

| Wrapper | Underlying | "Not set" sentinel |
|---------|------------|-------------------|
| `JsonString` | `string` | `null` |
| `JsonInt` | `int` | `int.MinValue` |
| `JsonFloat` | `double` | `double.NaN` |
| `JsonBool` | `bool` | `false` |
| `JsonDttm` | `DateTime` | `DateTime.MinValue` |

Use `JsonInt.IsSet` / `JsonFloat.IsSet` to distinguish an explicitly set value from an unset one.

### `AriaAccessObject` Base

Every serializable class inherits from `AriaAccessObject`. The `__type` string is set in each class's constructor and serialized first (`[JsonPropertyOrder(-2)]`). It carries Aria's type URI, e.g. `"GetMachineAppointmentsRequest:http://services.varian.com/AriaWebConnect/Link"`. The `__type` setter is `private` — only set it via the constructor `base(typeString)` call.

### DTO Naming Quirks

- `TretmentIntentType` in `PatientClinicalConcept` is **intentionally misspelled** to match the upstream Aria SOAP field name. Do not rename it.
- Property names on all DataTypes and Response classes must match the upstream API's JSON keys exactly. Use `[JsonPropertyName("OriginalName")]` if a property needs renaming for C# clarity (see `CancerStage.Criteria`).

### Environment-Specific Configuration

**These must be customized per Aria installation** — do not treat the existing values as defaults:

- `AriaAccessAPI/Enums/DepartmentIdEnum.cs` — `DepartmentId` enum values
- `AriaAccessAPI/Enums/HospitalIdEnum.cs` — `HospitalId` enum values
- `AriaAccessAPI/Enums/MachineIdEnum.cs` — `MachineId` enum values
- `AriaAccessAPI/Helpers/DeptAndHospitalEnumParser.cs` — string mappings for departments and hospitals (must match Aria Data Admin entries exactly)

### `Service.cs`

`AriaAccessAPI/Core/Service.cs` is an **auto-generated WCF service reference** (~817 KB). Do not edit it manually. It should be regenerated from the WSDL if the upstream Aria service contract changes.

### Request Validation

All Request constructors validate required string parameters with `ArgumentNullException` for null/empty values. The shared timestamp validation logic lives in `AriaAccessAPI/Requests/RequestHelpers.cs`.

### Mutation Requests

Create/Update requests (`CreatePatientRequest`, `UpdateMachineAppointmentRequest`, etc.) do not have corresponding typed Response classes. The raw string returned by `Communication.SendData` must be handled by the consumer.
