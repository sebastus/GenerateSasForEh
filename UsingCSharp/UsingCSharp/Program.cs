using Microsoft.ServiceBus;
using System;

namespace UsingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // example: https://namespace.servicebus.windows.net
            string ehNamespace = "namespace";

            // example: insights-telemetry-lad
            string eventHubName = "insights-telemetry-lad";

            // example: RootManageSharedAccessKey
            string hubPolicyName = "RootManageSharedAccessKey";

            // example: ZhLwp6lrVWQt5UFXXXXXXXXXXXXDuHWfY0J9RN1ctE=
            string hubPolicyKey = "your-policy-key";

            string resource = $"https://{ehNamespace}.servicebus.windows.net/{eventHubName}";

            string token = SharedAccessSignatureTokenProvider.GetSharedAccessSignature(
                hubPolicyName, hubPolicyKey,
                resource, new TimeSpan(365, 0, 0, 0));

            Console.WriteLine(token + "\r\n" + "Press any key");
            Console.ReadKey();
        }
    }
}
