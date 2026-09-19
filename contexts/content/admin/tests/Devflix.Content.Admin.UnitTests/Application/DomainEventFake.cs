using Devflix.Content.Admin.Domain.SeedWork;

namespace Devflix.Content.Admin.UnitTests.Application;

public sealed record DomainEventToBeHandledFake : DomainEvent;

public sealed record DomainEventToNotBeHandledFake : DomainEvent;