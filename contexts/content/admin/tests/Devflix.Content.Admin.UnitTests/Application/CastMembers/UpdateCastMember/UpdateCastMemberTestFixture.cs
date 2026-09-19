using Devflix.Content.Admin.UnitTests.Application.CastMembers.Common;

namespace Devflix.Content.Admin.UnitTests.Application.CastMembers.UpdateCastMember;

[CollectionDefinition(nameof(UpdateCastMemberTestFixture))]
public class UpdateCastMemberTestFixtureCollection
    : ICollectionFixture<UpdateCastMemberTestFixture>
{ }

public class UpdateCastMemberTestFixture 
    : CastMemberUseCasesBaseFixture
{ }
