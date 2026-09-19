using Devflix.Content.Admin.IntegrationTests.Application.UseCases.CastMembers.Common;

namespace Devflix.Content.Admin.IntegrationTests.Application.UseCases.CastMembers.CreateCastMember;

[CollectionDefinition(nameof(CreateCastMemberTestFixture))]
public class CreateCastMemberTestFixtureCollection
    : ICollectionFixture<CreateCastMemberTestFixture>
{
}

public class CreateCastMemberTestFixture
    : CastMemberUseCasesBaseFixture
{
}
