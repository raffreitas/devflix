using Devflix.Content.Admin.UnitTests.Common;

using Devflix.Content.Admin.Domain.Enum;

using DomainEntity = Devflix.Content.Admin.Domain.Entities;


namespace Devflix.Content.Admin.UnitTests.Application.CastMembers.Common;

public class CastMemberUseCasesBaseFixture
    : BaseFixture
{
    public DomainEntity.CastMember GetExampleCastMember()
        => new(GetValidName(), GetRandomCastMemberType());

    public string GetValidName()
        => Faker.Name.FullName();

    public CastMemberType GetRandomCastMemberType()
        => (CastMemberType)(new Random()).Next(1, 2);
}