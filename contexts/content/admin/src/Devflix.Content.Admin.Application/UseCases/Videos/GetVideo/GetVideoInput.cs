using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.GetVideo;

public sealed record GetVideoInput(Guid VideoId) : IRequest<VideoModelOutput>;