using Devflix.Content.Catalog.Application.Common;
using Devflix.Content.Catalog.Application.UseCases.Genres.Common;

using Devflix.Content.Catalog.Domain.Repositories.DTOs;

using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Genres.SearchGenre;

public sealed record SearchGenreInput(
    int Page = 1,
    int PerPage = 20,
    string Search = "",
    string OrderBy = "",
    SearchOrder Order = SearchOrder.Asc)
    : SearchListInput(Page, PerPage, Search, OrderBy, Order), IRequest<SearchListOutput<GenreModelOutput>>;