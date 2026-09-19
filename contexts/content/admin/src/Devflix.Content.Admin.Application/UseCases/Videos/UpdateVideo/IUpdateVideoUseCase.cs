using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.UpdateVideo;

public interface IUpdateVideoUseCase : IRequestHandler<UpdateVideoInput, VideoModelOutput>
{
}