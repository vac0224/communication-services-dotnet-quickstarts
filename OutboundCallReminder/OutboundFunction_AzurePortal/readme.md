---
page_type: sample
languages:
- csharp
products:
- azure
- azure-communication-services
---

# Outbound Azure Function Sample

This Azure function sample sends an SMS, makes an outbound call, or plays audio using Azure Communication Services SMS and Server Calling SDKs on the basis of JSON input given in the following format.

- `SendNotification`: value must be `true` to send the notification.
- `OutboundNumber`: Target phone number where you want to send the notification.
- `SourceNumber`: Phone number associated with the Azure Communication Services resource.
- `SMS.Send`: Value must be `true` or `false` if you want to send SMS (true) or not (false).
- `SMS.Message`: Message you want to send as SMS.
- `PhoneCall.Send`:  Value must be `true` or `false` if you want to make a phone call (true) or not (false).
- `PhoneCall.PlayAudioUrl`: The WAV file URL which is accessible by the function app. If the value is empty, then the sample uses the URL configured through Azure portal.

```csharp
{
  "SendNotification": "true",
  "SourceNumber":"+18xxxxxxxxxx",
  "OutboundNumber": "+18xxxxxxxxxx",
  "SMS": {
    "Send": "true",
    "Message": "message to be sent"
  },
  "PhoneCall": {
    "Send": "true",
    "PlayAudioUrl": "audio file URL function app can able to access"
  }
}
```

## Prerequisites

- Create an Azure account with an active subscription. For details, see [Create an account for free](https://azure.microsoft.com/free/).
- Create an Azure Communication Services resource. For details, see [Create an Azure Communication Resource](https://docs.microsoft.com/azure/communication-services/quickstarts/create-communication-resource). You need to record your resource **connection string** for this sample.
- Get a phone number for your new Azure Communication Services resource. For details, see [Get a phone number](https://docs.microsoft.com/azure/communication-services/quickstarts/telephony/get-phone-number?pivots=platform-azp).

## Code structure

- `./SendNotification/run.csx`: Azure function to send notification using phone call and SMS and to handle outbound callbacks.
- `./SendNotification/Phonecall.csx`: Class to handle outbound phone calls.
- `./SendNotification/SendSms.csx`: Class to send SMS notification.
- `./SendNotification/EventHandler/*.csx`: Code to manage callbacks and request authorization.
- `./SendNotification/function.proj`: Contains nuget package references.

## Create Function App using Azure portal

- [Create a Function App](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-function-app-portal#create-a-function-app).
- [Create a HTTP Trigger function `SendNotification` with Authorization level `Anonymous`](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-function-app-portal#create-function).
- After creating the function, edit `run.csx` and add other code files.

## Add code files using `kudu` Tool

- Under the Function app menu, select **Advanced tool** under **Development tools** section.
- Click **Go** > **Kudu** to open web in a new tab.
- From the **Debug Console" menu, select **CMD**.
- Add files in the `/site/wwwroot/SendNotification/` folder.

### Configuring Azure Function Sample

After publishing your function app, add the following configuration to your function app `configuration` section:

- Connectionstring: Azure Communication Service resource connection string.
- SourcePhone: Phone number associated with the Azure Communication Service resource.
- SecretPlaceholder: Secret/Password to be part of callback and used to validate incoming requests.
- AudioFileUrl: URL of default WAV file to play in outbound phone calls, which is accessible by the function app.
