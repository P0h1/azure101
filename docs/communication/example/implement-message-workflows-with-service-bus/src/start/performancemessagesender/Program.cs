using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;

namespace performancemessagesender
{
    class Program
    {
        const string ServiceBusConnectionString = "Endpoint=sb://okeanoso.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=fnShPvtx0UhdHrIzJcKhBB+UbSxbRsT7XRma5jXi5Zc=";
        const string QueueName = "salesmessages";

        const string TopicName = "salesperformancemessages";

        static void Main(string[] args)
        {

            Console.WriteLine("Sending a message to the Sales Performance topic...");

            SendPerformanceMessageAsync().GetAwaiter().GetResult();

            Console.WriteLine("Message was sent successfully.");

        }

        static async Task SendPerformanceMessageAsync()
        {
            await using var client = new ServiceBusClient(ServiceBusConnectionString);

            //await using ServiceBusSender sender = client.CreateSender(QueueName);
            await using ServiceBusSender sender = client.CreateSender(TopicName);

            // Send messages.
            try
            {
                string messageBody = $"$10,000 order for bicycle parts from retailer Adventure Works.";
                var message = new ServiceBusMessage(messageBody);
                Console.WriteLine($"Sending message: {messageBody}");
                await sender.SendMessageAsync(message);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{DateTime.Now} :: Exception: {exception.Message}");
            }
        }
    }
}
