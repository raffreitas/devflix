namespace Devflix.Content.Catalog.Application.Common;

public record SearchListOutput<T>(
    int CurrentPage,
    int PerPage,
    int Total,
    IReadOnlyList<T> Items
);