using Devflix.Content.Admin.Domain.Enum;

namespace Devflix.Content.Admin.Api.Models.CastMembers;

public sealed record UpdateCastMemberApiInput(string Name, CastMemberType Type)
{
    public string Name { get; set; } = Name;
    public CastMemberType Type { get; set; } = Type;
}