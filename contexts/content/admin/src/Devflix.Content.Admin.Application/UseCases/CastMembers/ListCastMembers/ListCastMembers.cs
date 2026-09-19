using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.ListCastMembers;

public class ListCastMembers(ICastMemberRepository repository) : IListCastMembers
{
    public async Task<ListCastMembersOutput> Handle(
        ListCastMembersInput request,
        CancellationToken cancellationToken
    )
    {
        var searchOutput = await repository.Search(request.ToSearchInput(), cancellationToken);
        return ListCastMembersOutput.FromSearchOutput(searchOutput);
    }
}