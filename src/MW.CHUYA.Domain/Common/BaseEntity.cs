using MW.CHUYA.Domain.Common.Interfaces;

namespace MW.CHUYA.Domain.Common;

public abstract class BaseEntity<TId> : IEntity<TId>
{
    // private
    // public
    public TId? Id { get; set; }
}
