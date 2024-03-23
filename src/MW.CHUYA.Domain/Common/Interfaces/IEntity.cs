namespace MW.CHUYA.Domain.Common.Interfaces;

public interface IEntity<TId> : IEntity
{
    TId? Id { get; set; }
}

public interface IEntity { }
