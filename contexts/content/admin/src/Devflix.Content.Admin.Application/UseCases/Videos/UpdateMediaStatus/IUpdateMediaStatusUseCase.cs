using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.UpdateMediaStatus;

public interface IUpdateMediaStatusUseCase : IRequestHandler<UpdateMediaStatusInput, VideoModelOutput>;