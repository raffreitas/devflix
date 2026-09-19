using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Videos.DeleteVideo;

public sealed record DeleteVideoInput(Guid VideoId) : IRequest;