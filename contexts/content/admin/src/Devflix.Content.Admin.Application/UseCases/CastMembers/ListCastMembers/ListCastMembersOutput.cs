using Devflix.Content.Admin.Application.Common;
using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

using DomainEntity = Devflix.Content.Admin.Domain.Entities;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.ListCastMembers;

public record ListCastMembersOutput(int Page, int PerPage, int Total, IReadOnlyList<CastMemberModelOutput> Items)
    : PaginatedListOutput<CastMemberModelOutput>(Page, PerPage, Total, Items)
{
    public static ListCastMembersOutput FromSearchOutput(
        SearchOutput<DomainEntity.CastMember> searchOutput
    ) => new(
        searchOutput.CurrentPage,
        searchOutput.PerPage,
        searchOutput.Total,
        searchOutput.Items
            .Select(castmember
                => CastMemberModelOutput.FromCastMember(castmember))
            .ToList()
            .AsReadOnly()
    );
}