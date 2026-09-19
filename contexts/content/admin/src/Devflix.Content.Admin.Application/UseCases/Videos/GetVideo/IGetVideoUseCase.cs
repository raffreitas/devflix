using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.GetVideo;

public interface IGetVideoUseCase : IRequestHandler<GetVideoInput, VideoModelOutput>
{
}