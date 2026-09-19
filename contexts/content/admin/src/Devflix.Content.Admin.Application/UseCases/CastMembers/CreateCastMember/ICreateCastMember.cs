using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.CreateCastMember;

public interface ICreateCastMember
    : IRequestHandler<CreateCastMemberInput, CastMemberModelOutput>
{
}
