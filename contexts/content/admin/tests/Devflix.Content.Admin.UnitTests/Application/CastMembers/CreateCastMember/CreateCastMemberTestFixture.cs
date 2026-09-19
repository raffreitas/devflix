using Devflix.Content.Admin.UnitTests.Application.CastMembers.Common;

namespace Devflix.Content.Admin.UnitTests.Application.CastMembers.CreateCastMember;

[CollectionDefinition(nameof(CreateCastMemberTestFixture))]
public class CreateCastMemberTestFixtureCollection
    : ICollectionFixture<CreateCastMemberTestFixture>
{ }

public class CreateCastMemberTestFixture
    : CastMemberUseCasesBaseFixture
{
}
