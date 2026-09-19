namespace Devflix.Content.Admin.Domain.SeedWork;

public abstract record DomainEvent
{
    public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
}