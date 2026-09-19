using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.GetCastMember;
public class GetCastMemberInput(Guid id) : IRequest<CastMemberModelOutput>
{
    public Guid Id { get; private set; } = id;
}
