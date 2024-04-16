
namespace MW.CHUYA.Domain.Common.Interfaces;

public interface IAuditableEntity<TId> : IAuditableEntity, IEntity<TId>
{
    int CreatedBy { get; set; }
    DateTime CreatedAt { get; set; }
    int UpdatedBy { get; set; }
    DateTime UpdatedAt { get; set; }
}

public interface IAuditableEntity { }