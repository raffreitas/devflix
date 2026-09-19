using HotChocolate.Execution;

namespace Devflix.Content.Catalog.Api.Filters;

public sealed class GraphQlErrorFilter : IErrorFilter
{
    public IError OnError(IError error)
    {
        return error.WithMessage(error.Exception?.Message ?? "Unexpected error.");
    }
}