using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test_22
{
    public class FileLogger
    {
        public string path = @"E:\Visual Studio Insader\Projects\Test 22\logPD21.txt";

        public void Subscribe(MessagePublisher publisher)
        {
            publisher.OnMessagePublished += WriteToFile;
        }

        public void WriteToFile(string message)
        {
            File.AppendAllText(path, $"{DateTime.Now}: {message}\n");
            Console.WriteLine("Saved: " + message);
        }
    }
}
