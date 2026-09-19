using Devflix.Content.Catalog.Domain.Repositories.DTOs;

namespace Devflix.Content.Catalog.Application.Common;

public record SearchListInput(int Page, int PerPage, string Search, string OrderBy, SearchOrder Order)
{
    public SearchInput ToSearchInput()
        => new(Page, PerPage, Search, OrderBy, Order);
}