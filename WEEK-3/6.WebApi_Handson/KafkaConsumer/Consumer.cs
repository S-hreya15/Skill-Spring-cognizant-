using Confluent.Kafka;

namespace KafkaConsumer
{
    public class Consumer
    {
        public static void ReceiveMessage()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer =
                new ConsumerBuilder<Ignore, string>(config).Build();

            consumer.Subscribe("chat-topic");

            while (true)
            {
                var result = consumer.Consume();

                Console.WriteLine("Received : " + result.Message.Value);
            }
        }
    }
}