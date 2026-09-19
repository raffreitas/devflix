using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using Devflix.Content.Admin.Domain.Repositories;

using DomainEntity = Devflix.Content.Admin.Domain.Entities;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.CreateCastMember;

public class CreateCastMember(ICastMemberRepository repository, IUnitOfWork unitOfWork) : ICreateCastMember
{
    public async Task<CastMemberModelOutput> Handle(CreateCastMemberInput request, CancellationToken cancellationToken)
    {
        var castMember = new DomainEntity.CastMember(request.Name, request.Type);
        await repository.Insert(castMember, cancellationToken);
        await unitOfWork.Commit(cancellationToken);
        return CastMemberModelOutput.FromCastMember(castMember);
    }
}