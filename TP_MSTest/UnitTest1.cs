using MessageDelegateApp;
using System;
using System.IO;

namespace MessageDelegateAppTests
{
    [TestClass]
    public class MessageDisplayTests
    {
        [TestMethod]
        public void TestShowMessage()
        {
            var messageDisplay = new MessageDisplay();
            
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            MessageDelegate showMessageDelegate = new MessageDelegate(messageDisplay.ShowMessage);
            showMessageDelegate("Test message");

            var output = stringWriter.ToString();
            Assert.AreEqual("Message: Test message\r\n", output);
        }

        [TestMethod]
        public void TestDisplayUppercaseMessage()
        {
            var messageDisplay = new MessageDisplay();

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            MessageDelegate displayUppercaseMessageDelegate = new MessageDelegate(messageDisplay.DisplayUppercaseMessage);
            displayUppercaseMessageDelegate("Test message");

            var output = stringWriter.ToString();
            Assert.AreEqual("Message in Uppercase: TEST MESSAGE\r\n", output);
        }

        [TestMethod]
        public void TestCallDelegate()
        {
            var messageDisplay = new MessageDisplay();
            
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            MessageDelegate showMessageDelegate = new MessageDelegate(messageDisplay.ShowMessage);
            messageDisplay.CallDelegate(showMessageDelegate, "Test message");

            var output = stringWriter.ToString();
            Assert.AreEqual("Message: Test message\r\n", output);
        }
    }
}
