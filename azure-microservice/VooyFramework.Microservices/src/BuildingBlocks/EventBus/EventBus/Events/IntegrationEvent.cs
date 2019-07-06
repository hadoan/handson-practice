using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VooyFramework.Microservices.BuildingBlocks.EventBus.Events
{
    public class IntegrationEvent
    {

        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }

        public IntegrationEvent(Guid id,DateTime creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }

        [JsonProperty]
        public Guid Id { get; private set; }
        [JsonProperty]
        public DateTime CreationDate { get; private set; }
    }
}
