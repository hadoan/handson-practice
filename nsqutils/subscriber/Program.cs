using System;
using KonbiBrain.Messages;
using NsqSharp;

namespace subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var consumer = new Consumer("testtopic", NsqConstants.NsqDefaultChannel);
            consumer.AddHandler(new MessageHandler());
            Console.WriteLine(NsqConstants.NsqUrlConsumer);
            consumer.ConnectToNsqLookupd(NsqConstants.NsqUrlConsumer);

            while (true)
            {
                System.Threading.Thread.Sleep(1000);
            }
            // consumer.Close();
        }
    }
}
