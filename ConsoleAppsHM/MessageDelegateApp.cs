using System;

namespace MessageDelegateApp
{
    public delegate void MessageDelegate(string message);

    public class MessageDisplay
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public void DisplayUppercaseMessage(string message)
        {
            Console.WriteLine($"Message in Uppercase: {message.ToUpper()}");
        }

        public void CallDelegate(MessageDelegate messageDelegate, string message)
        {
            messageDelegate(message);
        }
    }
}