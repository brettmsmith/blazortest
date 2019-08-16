namespace blazortest.Data
{
    public class ChatService
    {
        public delegate void MessageHandler(string message);
        public event MessageHandler MessageReceived;

        public void Send(string message)
        {
            MessageReceived(message);
        }
    }
}