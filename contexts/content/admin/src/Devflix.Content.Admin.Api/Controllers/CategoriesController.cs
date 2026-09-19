using Devflix.Content.Admin.Api.Authorization;
using Devflix.Content.Admin.Api.Models.Categories;
using Devflix.Content.Admin.Api.Models.Responses;
using Devflix.Content.Admin.Application.UseCases.Categories.Common;
using Devflix.Content.Admin.Application.UseCases.Categories.CreateCategory;
using Devflix.Content.Admin.Application.UseCases.Categories.DeleteCategory;
using Devflix.Content.Admin.Application.UseCases.Categories.GetCategory;
using Devflix.Content.Admin.Application.UseCases.Categories.ListCategories;
using Devflix.Content.Admin.Application.UseCases.Categories.UpdateCategory;
using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Devflix.Content.Admin.Api.Controllers;

[ApiController]
[Route("categories")]
[Authorize(Roles = $"{Roles.Categories},{Roles.Admin}")]
public class CategoriesController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType<TestApiResponseList<CategoryModelOutput>>(StatusCodes.Status200OK)]
    public async Task<IActionResult> List(
        CancellationToken cancellationToken,
        [FromQuery] int? page = null,
        [FromQuery(Name = "per_page")] int? perPage = null,
        [FromQuery] string? search = null,
        [FromQuery] string? sort = null,
        [FromQuery] SearchOrder? dir = null
    )
    {
        var input = new ListCategoriesInput();

        if (page is not null) input.Page = page.Value;
        if (perPage is not null) input.PerPage = perPage.Value;
        if (!string.IsNullOrWhiteSpace(search)) input.Search = search;
        if (!string.IsNullOrWhiteSpace(sort)) input.Sort = sort;
        if (dir is not null) input.Dir = dir.Value;

        var output = await mediator.Send(input, cancellationToken);
        return Ok(new TestApiResponseList<CategoryModelOutput>(output));
    }

    [HttpPost]
    [ProducesResponseType<ApiResponse<CategoryModelOutput>>(StatusCodes.Status201Created)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> Create(
        [FromBody] CreateCategoryInput input,
        CancellationToken cancellationToken
    )
    {
        var output = await mediator.Send(input, cancellationToken);

        return CreatedAtAction(
            nameof(GetById),
            new { output.Id },
            new ApiResponse<CategoryModelOutput>(output)
        );
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType<ApiResponse<CategoryModelOutput>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(
        [FromRoute] Guid id,
        CancellationToken cancellationToken
    )
    {
        var output = await mediator.Send(new GetCategoryInput(id), cancellationToken);
        return Ok(new ApiResponse<CategoryModelOutput>(output));
    }

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(
        [FromRoute] Guid id,
        CancellationToken cancellationToken
    )
    {
        await mediator.Send(new DeleteCategoryInput(id), cancellationToken);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType<ApiResponse<CategoryModelOutput>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateCategoryApiInput apiInput,
        CancellationToken cancellationToken
    )
    {
        var input = new UpdateCategoryInput(
            id,
            apiInput.Name,
            apiInput.Description,
            apiInput.IsActive);

        var output = await mediator.Send(input, cancellationToken);
        return Ok(new ApiResponse<CategoryModelOutput>(output));
    }
}