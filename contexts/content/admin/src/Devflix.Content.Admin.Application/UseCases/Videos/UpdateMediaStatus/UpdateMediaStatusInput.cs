using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using Devflix.Content.Admin.Domain.Enum;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.UpdateMediaStatus;

public sealed record UpdateMediaStatusInput(
    Guid VideoId,
    MediaStatus Status,
    string? EncodedPath = null,
    string? ErrorMessage = null
) : IRequest<VideoModelOutput>;