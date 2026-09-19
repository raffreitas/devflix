using Devflix.Content.Admin.Application.UseCases.Videos.UpdateMediaStatus;
using Devflix.Content.Admin.UnitTests.Common.Fixtures;

using Devflix.Content.Admin.Domain.Enum;

namespace Devflix.Content.Admin.UnitTests.Application.Videos.UpdateMediaStatus;

public sealed class UpdateMediaStatusTestFixture : VideoTestFixtureBase
{
    public UpdateMediaStatusInput GetSucceededEncodingInput(Guid videoId) => new(
        videoId,
        MediaStatus.Completed,
        EncodedPath: GetValidMediaPath());

    public UpdateMediaStatusInput GetFailedEncodingInput(Guid videoId) => new(
        videoId,
        MediaStatus.Error,
        ErrorMessage: "There was an error while trying to encode video.");

    public UpdateMediaStatusInput GetInvalidStatusInput(Guid videoId) => new(
        videoId,
        MediaStatus.Processing,
        ErrorMessage: "There was an error while trying to encode video.");
}