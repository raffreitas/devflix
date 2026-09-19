using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.DeleteCastMember;
public class DeleteCastMemberInput(Guid id) : IRequest
{
    public Guid Id { get; private set; } = id;
}
