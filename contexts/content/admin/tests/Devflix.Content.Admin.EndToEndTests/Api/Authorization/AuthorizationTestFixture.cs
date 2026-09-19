using Devflix.Content.Admin.EndToEndTests.Base;

namespace Devflix.Content.Admin.EndToEndTests.Api.Authorization;

[CollectionDefinition(nameof(AuthorizationTestFixture))]
public class AuthorizationTestFixtureCollection : ICollectionFixture<AuthorizationTestFixture>
{
}

public sealed class AuthorizationTestFixture : BaseFixture
{
}