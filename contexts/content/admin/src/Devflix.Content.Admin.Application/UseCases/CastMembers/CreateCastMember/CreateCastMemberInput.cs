using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using Devflix.Content.Admin.Domain.Enum;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.CreateCastMember;
public class CreateCastMemberInput(string name, CastMemberType type) : IRequest<CastMemberModelOutput>
{
    public string Name { get; private set; } = name;
    public CastMemberType Type { get; private set; } = type;
}
