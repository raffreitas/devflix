using Devflix.Content.Admin.Application.UseCases.Videos.Common;

using Devflix.Content.Admin.Domain.Repositories;

namespace Devflix.Content.Admin.Application.UseCases.Videos.GetVideo;

public sealed class GetVideoUseCase(IVideoRepository videoRepository) : IGetVideoUseCase
{
    public async Task<VideoModelOutput> Handle(GetVideoInput request, CancellationToken cancellationToken)
    {
        var video = await videoRepository.Get(request.VideoId, cancellationToken);
        return VideoModelOutput.FromVideo(video);
    }
}