using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.GetCastMember;

public class GetCastMember(ICastMemberRepository repository) : IGetCastMember
{
    public async Task<CastMemberModelOutput> Handle(
        GetCastMemberInput request,
        CancellationToken cancellationToken
    )
    {
        var castMember = await repository.Get(request.Id, cancellationToken);
        return CastMemberModelOutput.FromCastMember(castMember);
    }
}