namespace Devflix.Content.Catalog.Domain.Exceptions;

public sealed class NotFoundException(string? message) : BusinessRuleException(message)
{
}