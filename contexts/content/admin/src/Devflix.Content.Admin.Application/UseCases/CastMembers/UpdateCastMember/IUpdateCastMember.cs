using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.UpdateCastMember;
public interface IUpdateCastMember
    : IRequestHandler<UpdateCastMemberInput, CastMemberModelOutput>
{
}
