using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.UploadMedias;

public sealed record UploadMediasInput(
    Guid VideoId,
    FileInput? VideoFile = null,
    FileInput? TrailerFile = null,
    FileInput? BannerFile = null,
    FileInput? ThumbFile = null,
    FileInput? ThumbHalfFile = null
) : IRequest;