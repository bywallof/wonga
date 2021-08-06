using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Wonga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wonga.\nOur main goal is reading what has been sent by WongaSender.\n");

            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new System.Uri("amqp://guest:guest@localhost:8000");

            IConnection connection = factory.CreateConnection();
            var f = connection.CreateModel();
            f.QueueDeclare("WONGA_QUEUE", durable: true, exclusive: false, autoDelete: true, arguments: null);

            //timeout = 60 seconds (a minute)
            f.ContinuationTimeout = TimeSpan.FromMilliseconds(60*1000); 

            EventingBasicConsumer consumer = new EventingBasicConsumer(f);
            consumer.Received += (s, ev) =>
            {
                byte[] nameByte = ev.Body.ToArray();
                String name = Encoding.UTF8.GetString(nameByte);
                String output = "Hello, " + name +", I am your father!";
                Console.WriteLine(output);
            };
            Console.Read();
        }
    }
}
