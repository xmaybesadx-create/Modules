using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test_22
{
    public class MessagePublisher
    {
        public delegate void MessageHandler(string message);

        public event MessageHandler OnMessagePublished;

        public void PublishMessage(string message)
        {
            OnMessagePublished?.Invoke(message);
        }
    }
}
