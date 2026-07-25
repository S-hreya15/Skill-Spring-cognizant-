namespace KafkaProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter Message : ");

            string message = Console.ReadLine();

            await Producer.SendMessage(message);
        }
    }
}