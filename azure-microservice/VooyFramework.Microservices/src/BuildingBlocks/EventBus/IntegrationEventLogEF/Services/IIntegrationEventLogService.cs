using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VooyFramework.Microservices.BuildingBlocks.IntegrationEventLogEF.Services
{
    public interface IIntegrationEventLogService
    {
        System.Threading.Tasks.Task<IEnumerable<IntegrationEventLogEntry>> RetrieveEventLogsPendingToPublishAsync(Guid transactionId);
        Task SaveEventAsync(EventBus.Events.IntegrationEvent @event, Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction);
        Task MarkEventAsPublishedAsync(Guid eventId);
        Task MarkEventAsInProgressAsync(Guid eventId);
        Task MarkEventAsFailedAsync(Guid eventId);
    }
}
