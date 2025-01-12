using System;
using MessageDelegateApp;

class Program
{
    static void Main()
    {
        var messageDisplay = new MessageDisplay();

        MessageDelegate showMessageDelegate = new MessageDelegate(messageDisplay.ShowMessage);
        MessageDelegate displayUppercaseMessageDelegate = new MessageDelegate(messageDisplay.DisplayUppercaseMessage);

        Console.WriteLine("Calling ShowMessage delegate:");
        messageDisplay.CallDelegate(showMessageDelegate, "Hello, this is a normal message.");

        Console.WriteLine("\nCalling DisplayUppercaseMessage delegate:");
        messageDisplay.CallDelegate(displayUppercaseMessageDelegate, "Hello, this is an uppercase message.");
    }
}