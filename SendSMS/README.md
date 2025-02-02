---
page_type: sample
languages:
- csharp
products:
- azure
- azure-communication-services
---


# Send an SMS Message Quickstart

For full instructions to build this code sample from scratch, see [Send an SMS Message](https://docs.microsoft.com/azure/communication-services/quickstarts/telephony/send?pivots=programming-language-csharp).

## Prerequisites

- An Azure account with an active subscription. [Create an account for free](https://azure.microsoft.com/free/?WT.mc_id=A261C142F).
- Install [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- The latest version [.NET Core client library](https://dotnet.microsoft.com/download/dotnet-core) for your operating system.
- An active Communication Services resource and connection string. [Create a Communication Services resource](https://docs.microsoft.com/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-net).
- An SMS enabled telephone number. [Get a phone number](https://docs.microsoft.com/azure/communication-services/quickstarts/telephony/get-phone-number?pivots=programming-language-csharp).

## Code Structure

- `./SendSMS/Program.cs`: Core application code with send SMS implementation.
- `./SendSMS/SendSMS.csproj`: Project configuration file.
- `./Samples.sln`: Visual Studio solution.

## Before running sample code

1. Open an instance of PowerShell, Windows Terminal, Command Prompt or equivalent and navigate to the directory where you'd like to clone the sample .
2. `git clone https://github.com/Azure-Samples/Communication-Services-dotnet-quickstarts.git`
3. With the **Connection String** procured in pre-requisites, add it to the `SendSMS/program.cs` file. Assign your connection string in line 3:
   ```const string connectionString = "YOUR_CONNECTION_STRING";```
4. With the SMS enabled telephone number procured in prerequisites, add it to the `SendSMS/program.cs` file. Assign your telephone number in line 13:
   ```from: new PhoneNumber("+1YOUR-PHONE-NUMBER"),```

## Run Locally

1. Open the `SendSMS.sln` file.
2. Run the `SendSMS` project.
