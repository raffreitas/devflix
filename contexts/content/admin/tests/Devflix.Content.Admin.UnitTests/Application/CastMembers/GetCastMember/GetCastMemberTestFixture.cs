using Devflix.Content.Admin.UnitTests.Application.CastMembers.Common;

namespace Devflix.Content.Admin.UnitTests.Application.CastMembers.GetCastMember;

[CollectionDefinition(nameof(GetCastMemberTestFixture))]
public class GetCastMemberTestFixtureCollection
    : ICollectionFixture<GetCastMemberTestFixture>
{ }

public class GetCastMemberTestFixture
    : CastMemberUseCasesBaseFixture
{ }
