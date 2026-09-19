using Devflix.Content.Admin.Application.Common;

using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.ListCastMembers;

public record ListCastMembersInput(int Page, int PerPage, string Search, string Sort, SearchOrder Dir)
    : PaginatedListInput(Page, PerPage, Search, Sort, Dir), IRequest<ListCastMembersOutput>
{
    public ListCastMembersInput()
        : this(1, 15, "", "", SearchOrder.Asc)
    {
    }
}