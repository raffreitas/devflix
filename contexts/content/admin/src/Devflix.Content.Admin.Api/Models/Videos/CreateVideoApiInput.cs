using Devflix.Content.Admin.Application.UseCases.Videos.CreateVideo;
using Devflix.Content.Admin.Domain.Extensions;

namespace Devflix.Content.Admin.Api.Models.Videos;

public sealed record CreateVideoApiInput
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int YearLaunched { get; set; }
    public bool Opened { get; set; }
    public bool Published { get; set; }
    public int Duration { get; set; }
    public string? Rating { get; set; }
    public List<Guid>? CategoriesIds { get; set; }
    public List<Guid>? GenresIds { get; set; }
    public List<Guid>? CastMembersIds { get; set; }

    public CreateVideoInput ToCreateVideoInput()
        => new(
            Title,
            Description,
            YearLaunched,
            Duration,
            Opened,
            Published,
            Rating.ToRating(),
            CategoriesIds?.AsReadOnly(),
            GenresIds?.AsReadOnly(),
            CastMembersIds?.AsReadOnly());
}