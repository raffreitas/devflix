using Devflix.Content.Admin.Domain.SeedWork;

namespace Devflix.Content.Admin.Domain.Events;

public sealed record VideoUploadedEvent(Guid ResourceId, string FilePath) : DomainEvent;