using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VooyFramework.Microservices.Product.API.Application.IntegrationEvents
{
    
    public interface IProductIntegrationEventService
    {
        Task PublishEventsThroughEventBusAsync(Guid transactionId);
        Task AddAndSaveEventAsync(BuildingBlocks.EventBus.Events.IntegrationEvent evt);
    }
}
