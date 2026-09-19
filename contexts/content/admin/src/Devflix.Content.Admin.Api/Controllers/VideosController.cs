using Devflix.Content.Admin.Api.Authorization;
using Devflix.Content.Admin.Api.Models.Responses;
using Devflix.Content.Admin.Api.Models.Videos;
using Devflix.Content.Admin.Application.UseCases.Videos.Common;
using Devflix.Content.Admin.Application.UseCases.Videos.DeleteVideo;
using Devflix.Content.Admin.Application.UseCases.Videos.GetVideo;
using Devflix.Content.Admin.Application.UseCases.Videos.ListVideos;
using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Devflix.Content.Admin.Api.Controllers;

[ApiController]
[Route("videos")]
[Authorize(Policy = Policies.VideosManager)]
public class VideosController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponse<VideoModelOutput>), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> CreateVideo(
        [FromBody] CreateVideoApiInput request,
        CancellationToken cancellationToken)
    {
        var input = request.ToCreateVideoInput();
        var output = await mediator.Send(input, cancellationToken);
        return CreatedAtAction(
            nameof(CreateVideo),
            new { id = output.Id },
            new ApiResponse<VideoModelOutput>(output));
    }

    [HttpGet]
    [ProducesResponseType(typeof(ListVideosOutput), StatusCodes.Status200OK)]
    public async Task<IActionResult> List(
        CancellationToken cancellationToken,
        [FromQuery] int? page = null,
        [FromQuery(Name = "per_page")] int? perPage = null,
        [FromQuery] string? search = null,
        [FromQuery] string? sort = null,
        [FromQuery] SearchOrder? dir = null
    )
    {
        var input = new ListVideosInput();
        if (page is not null) input.Page = page.Value;
        if (perPage is not null) input.PerPage = perPage.Value;
        if (!string.IsNullOrWhiteSpace(search)) input.Search = search;
        if (!string.IsNullOrWhiteSpace(sort)) input.Sort = sort;
        if (dir is not null) input.Dir = dir.Value;

        var output = await mediator.Send(input, cancellationToken);
        return Ok(
            new ApiResponseList<VideoModelOutput>(output)
        );
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(ApiResponse<VideoModelOutput>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(
        [FromRoute] Guid id,
        CancellationToken cancellationToken
    )
    {
        var output = await mediator.Send(new GetVideoInput(id), cancellationToken);
        return Ok(new ApiResponse<VideoModelOutput>(output));
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(ApiResponse<VideoModelOutput>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> UpdateVideo(
        [FromRoute] Guid id,
        [FromBody] UpdateVideoApiInput apiInput,
        CancellationToken cancellationToken)
    {
        var output = await mediator.Send(apiInput.ToInput(id), cancellationToken);
        return Ok(new ApiResponse<VideoModelOutput>(output));
    }

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteVideo(
        [FromRoute] Guid id,
        CancellationToken cancellationToken)
    {
        await mediator.Send(new DeleteVideoInput(id), cancellationToken);
        return NoContent();
    }

    [HttpPost("{id:guid}/medias/{type}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UploadMedia(
        [FromRoute] Guid id,
        [FromRoute] string type,
        [FromForm] UploadMediaApiInput apiInput,
        CancellationToken cancellationToken)
    {
        var input = apiInput.ToUploadMediasInput(id, type);
        await mediator.Send(input, cancellationToken);
        return NoContent();
    }
}