using Devflix.Content.Admin.UnitTests.Application.CastMembers.Common;

namespace Devflix.Content.Admin.UnitTests.Application.CastMembers.DeleteCastMember;

[CollectionDefinition(nameof(DeleteCastMemberFixture))]
public class DeleteCastMemberFixtureCollection
    : ICollectionFixture<DeleteCastMemberFixture>
{ }

public class DeleteCastMemberFixture
    : CastMemberUseCasesBaseFixture
{ }
