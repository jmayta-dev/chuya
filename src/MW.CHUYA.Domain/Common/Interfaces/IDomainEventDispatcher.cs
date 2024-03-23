namespace MW.CHUYA.Domain.Common.Interfaces;

public interface IDomainEventDispatcher<TId>
{
    Task DispatchAndClearEvents(IEnumerable<BaseEntity<TId>> entitiesWithEvents);
}