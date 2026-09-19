using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.UpdateCastMember;

public class UpdateCastMember(ICastMemberRepository repository, IUnitOfWork unitOfWork) : IUpdateCastMember
{
    public async Task<CastMemberModelOutput> Handle(
        UpdateCastMemberInput input,
        CancellationToken cancellationToken
    )
    {
        var castmember = await repository.Get(input.Id, cancellationToken);
        castmember.Update(input.Name, input.Type);
        await repository.Update(castmember, cancellationToken);
        await unitOfWork.Commit(cancellationToken);
        return CastMemberModelOutput.FromCastMember(castmember);
    }
}