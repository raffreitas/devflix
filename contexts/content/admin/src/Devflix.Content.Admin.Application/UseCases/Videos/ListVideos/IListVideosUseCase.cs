using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.ListVideos;

public interface IListVideosUseCase : IRequestHandler<ListVideosInput, ListVideosOutput>
{
}