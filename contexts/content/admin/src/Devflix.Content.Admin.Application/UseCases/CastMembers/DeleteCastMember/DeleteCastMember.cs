using Devflix.Content.Admin.Application.Interfaces;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.DeleteCastMember;

public class DeleteCastMember(
    ICastMemberRepository repository,
    IUnitOfWork unitOfWork)
    : IDeleteCastMember
{
    public async Task Handle(
        DeleteCastMemberInput request,
        CancellationToken cancellationToken
    )
    {
        var castMember = await repository.Get(request.Id, cancellationToken);
        await repository.Delete(castMember, cancellationToken);
        await unitOfWork.Commit(cancellationToken);
    }
}