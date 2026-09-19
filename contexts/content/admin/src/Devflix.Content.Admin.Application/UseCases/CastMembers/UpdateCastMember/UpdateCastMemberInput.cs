using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;

using Devflix.Content.Admin.Domain.Enum;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.UpdateCastMember;

public class UpdateCastMemberInput(Guid id, string name, CastMemberType type) : IRequest<CastMemberModelOutput>
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public CastMemberType Type { get; set; } = type;
}