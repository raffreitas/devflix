using Bogus;

using Devflix.Content.Admin.Infra.Data.EF;

using Microsoft.EntityFrameworkCore;

namespace Devflix.Content.Admin.IntegrationTests.Base;
public abstract class BaseFixture
{
    protected Faker Faker { get; } = new Faker("pt_BR");
    public DevflixContentAdminDbContext CreateDbContext(bool preserveData = false)
    {
        var dbContext = new DevflixContentAdminDbContext(
            new DbContextOptionsBuilder<DevflixContentAdminDbContext>()
                .UseInMemoryDatabase("integration-tests-db")
                .Options
        );

        if (!preserveData)
            dbContext.Database.EnsureDeleted();

        return dbContext;
    }
}
