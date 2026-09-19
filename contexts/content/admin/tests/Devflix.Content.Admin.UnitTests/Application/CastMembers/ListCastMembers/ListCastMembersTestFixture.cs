using Devflix.Content.Admin.UnitTests.Application.CastMembers.Common;

using DomainEntity = Devflix.Content.Admin.Domain.Entities;

namespace Devflix.Content.Admin.UnitTests.Application.CastMembers.ListCastMembers;

[CollectionDefinition(nameof(ListCastMembersTestFixture))]
public class ListCastMembersTestFixtureCollection
    : ICollectionFixture<ListCastMembersTestFixture>
{
}

public class ListCastMembersTestFixture
    : CastMemberUseCasesBaseFixture
{
    public List<DomainEntity.CastMember> GetExampleCastMembersList(int quantity)
        => Enumerable
            .Range(1, quantity)
            .Select(_ => GetExampleCastMember())
            .ToList();
}