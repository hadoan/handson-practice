using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VooyFramework.Microservices.BuildingBlocks.EventBus.Events;

namespace VooyFramework.Microservices.BuildingBlocks.EventBus.Abstractions
{
    public interface IIntegrationEventHandler
    {

    }

    public interface IIntegrationEventHandler<in TIntegrationEvent>:IIntegrationEventHandler
        where TIntegrationEvent:IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }
}
