using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.CreateVideo;

public interface ICreateVideoUseCase : IRequestHandler<CreateVideoInput, VideoModelOutput>
{
}