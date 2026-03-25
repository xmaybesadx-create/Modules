using System;
using System.IO;
using System.Collections.Generic;
using Test_22;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger();

            logger.Subscribe(publisher);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter message: ");
                string text = Console.ReadLine();

                publisher.PublishMessage(text);
            }
        }
    }
}