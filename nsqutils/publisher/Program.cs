using System;
using KonbiBrain.Common.Services;

namespace publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var publisher=new NsqMessageProducerService();
            
            int i=0;
            while(true)
            {
                i++;
                publisher.SendNsqCommand("testtopic","this is test "+i);
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
