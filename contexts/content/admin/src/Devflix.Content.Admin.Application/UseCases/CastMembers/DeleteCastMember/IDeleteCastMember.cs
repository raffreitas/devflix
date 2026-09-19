using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.DeleteCastMember;
public interface IDeleteCastMember
    : IRequestHandler<DeleteCastMemberInput>
{ }
