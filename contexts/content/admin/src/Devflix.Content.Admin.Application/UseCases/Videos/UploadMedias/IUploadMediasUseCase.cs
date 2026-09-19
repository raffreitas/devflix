using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.UploadMedias;

public interface IUploadMediasUseCase : IRequestHandler<UploadMediasInput>
{
}
