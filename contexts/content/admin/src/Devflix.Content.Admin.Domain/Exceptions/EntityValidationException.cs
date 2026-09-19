using Devflix.Content.Admin.Domain.Validations;

namespace Devflix.Content.Admin.Domain.Exceptions;

public class EntityValidationException(
    string? message,
    IReadOnlyCollection<ValidationError>? errors = null
) : Exception(message)
{
    public IReadOnlyCollection<ValidationError>? Errors { get; } = errors;
}