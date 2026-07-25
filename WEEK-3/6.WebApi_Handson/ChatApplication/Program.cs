namespace ChatApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatClient chat = new ChatClient();

            chat.Start();
        }
    }
}