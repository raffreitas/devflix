using Devflix.Content.Admin.Application.UseCases.Videos.DeleteVideo;
using Devflix.Content.Admin.UnitTests.Common.Fixtures;

namespace Devflix.Content.Admin.UnitTests.Application.Videos.DeleteVideo;

public sealed class DeleteVideoTestFixture : VideoTestFixtureBase
{
    public DeleteVideoInput GetValidInput(Guid? id = null) => new(id ?? Guid.NewGuid());
}