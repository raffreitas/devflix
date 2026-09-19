using Devflix.Content.Admin.Api.Authorization;
using Devflix.Content.Admin.Api.Models.CastMembers;
using Devflix.Content.Admin.Api.Models.Responses;

using Devflix.Content.Admin.Application.UseCases.CastMembers.Common;
using Devflix.Content.Admin.Application.UseCases.CastMembers.CreateCastMember;
using Devflix.Content.Admin.Application.UseCases.CastMembers.DeleteCastMember;
using Devflix.Content.Admin.Application.UseCases.CastMembers.GetCastMember;
using Devflix.Content.Admin.Application.UseCases.CastMembers.ListCastMembers;
using Devflix.Content.Admin.Application.UseCases.CastMembers.UpdateCastMember;
using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Devflix.Content.Admin.Api.Controllers;

[ApiController]
[Route("cast_members")]
[Authorize(Roles = $"{Roles.CastMembers},{Roles.Admin}")]
public class CastMembersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponse<CastMemberModelOutput>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> Create(
        [FromBody] CreateCastMemberInput input,
        CancellationToken cancellationToken
    )
    {
        var output = await mediator.Send(input, cancellationToken);
        return CreatedAtAction(
            nameof(GetById),
            new { output.Id },
            new ApiResponse<CastMemberModelOutput>(output)
        );
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(ApiResponse<CastMemberModelOutput>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(
        [FromRoute] Guid id,
        CancellationToken cancellationToken
    )
    {
        var output = await mediator.Send(new GetCastMemberInput(id), cancellationToken);
        return Ok(new ApiResponse<CastMemberModelOutput>(output));
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(ApiResponse<CastMemberModelOutput>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateCastMemberApiInput apiInput,
        CancellationToken cancellationToken
    )
    {
        var output = await mediator.Send(
            new UpdateCastMemberInput(id, apiInput.Name, apiInput.Type),
            cancellationToken
        );
        return Ok(new ApiResponse<CastMemberModelOutput>(output));
    }

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await mediator.Send(new DeleteCastMemberInput(id), cancellationToken);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ApiResponseList<CastMemberModelOutput>), StatusCodes.Status200OK)]
    public async Task<IActionResult> List(
        [FromQuery] int? page,
        [FromQuery(Name = "per_page")] int? perPage,
        [FromQuery] string? search,
        [FromQuery] string? dir,
        [FromQuery] string? sort,
        CancellationToken cancellationToken
    )
    {
        var input = new ListCastMembersInput();
        if (page is not null) input.Page = page.Value;
        if (perPage is not null) input.PerPage = perPage.Value;
        if (search is not null) input.Search = search;
        if (dir is not null) input.Dir = dir.ToLower() == "asc" ? SearchOrder.Asc : SearchOrder.Desc;
        if (sort is not null) input.Sort = sort;
        var output = await mediator.Send(input, cancellationToken);
        return Ok(new ApiResponseList<CastMemberModelOutput>(output));
    }
}