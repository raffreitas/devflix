using Devflix.Content.Admin.UnitTests.Common;

using Devflix.Content.Admin.Domain.Entities;
using Devflix.Content.Admin.Domain.Enum;

namespace Devflix.Content.Admin.UnitTests.Domain.Entities.CastMembers;

[CollectionDefinition(nameof(CastMemberTestFixture))]
public class CastMemberTestFixtureCollection
    : ICollectionFixture<CastMemberTestFixture>
{
}

public class CastMemberTestFixture : BaseFixture
{
    public CastMember GetExampleCastMember()
        => new CastMember(
            GetValidName(),
            GetRandomCastMemberType()
        );

    public string GetValidName()
        => Faker.Name.FullName();

    public CastMemberType GetRandomCastMemberType()
        => (CastMemberType)(new Random()).Next(1, 2);
}