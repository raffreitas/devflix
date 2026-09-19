using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.DeleteVideo;

public interface IDeleteVideoUseCase : IRequestHandler<DeleteVideoInput>{}