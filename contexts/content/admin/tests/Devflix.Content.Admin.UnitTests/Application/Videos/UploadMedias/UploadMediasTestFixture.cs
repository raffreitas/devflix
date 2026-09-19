using Devflix.Content.Admin.Application.UseCases.Videos.UploadMedias;
using Devflix.Content.Admin.UnitTests.Common.Fixtures;

namespace Devflix.Content.Admin.UnitTests.Application.Videos.UploadMedias;

public sealed class UploadMediasTestFixture : VideoTestFixtureBase
{
    public UploadMediasInput GetValidInput(
        Guid? videoId = null,
        bool withVideoFile = true,
        bool withTrailerFile = true,
        bool withBannerFile = true,
        bool withThumbFile = true,
        bool withThumbHalfFile = true
    ) => new(
        videoId ?? Guid.NewGuid(),
        withVideoFile ? GetValidMediaFileInput() : null,
        withTrailerFile ? GetValidMediaFileInput() : null,
        withBannerFile ? GetValidMediaFileInput() : null,
        withThumbFile ? GetValidMediaFileInput() : null,
        withThumbHalfFile ? GetValidMediaFileInput() : null
    );
}