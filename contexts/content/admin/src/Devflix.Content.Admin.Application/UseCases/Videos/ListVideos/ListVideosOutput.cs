using Devflix.Content.Admin.Application.Common;
using Devflix.Content.Admin.Application.UseCases.Videos.Common;

namespace Devflix.Content.Admin.Application.UseCases.Videos.ListVideos;

public sealed record ListVideosOutput(
    int Page,
    int PerPage,
    int Total,
    IReadOnlyList<VideoModelOutput> Items)
    : PaginatedListOutput<VideoModelOutput>(Page, PerPage, Total, Items);