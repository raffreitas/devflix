using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.GetCastMember;
public interface IGetCastMember
    : IRequestHandler<GetCastMemberInput, CastMemberModelOutput>
{}
