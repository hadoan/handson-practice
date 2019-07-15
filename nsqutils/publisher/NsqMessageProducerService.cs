using System;
using System.Text;
using KonbiBrain.Messages;
using Newtonsoft.Json;
using NsqSharp;

namespace KonbiBrain.Common.Services
{
    public class NsqMessageProducerService
    {
        public void SendNsqCommand(string nsqTopic, object command)
        {
            try
            {
                var producer = new Producer(NsqConstants.NsqUrlProducer);
                var commandStr = Newtonsoft.Json.JsonConvert.SerializeObject(command);
                producer.Publish(nsqTopic, Encoding.UTF8.GetBytes(commandStr));
                //LogService.NsqCommandLog.Information("Producer: topic - " + nsqTopic + " cmd: " + JsonConvert.SerializeObject(command));
                producer.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
