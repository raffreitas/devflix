using Devflix.Content.Admin.Application.Common;

using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Genres.ListGenres;
public record ListGenresInput(
    int Page = 1,
    int PerPage = 15,
    string Search = "",
    string Sort = "",
    SearchOrder Dir = SearchOrder.Asc)
    : PaginatedListInput(Page, PerPage, Search, Sort, Dir), IRequest<ListGenresOutput>;
