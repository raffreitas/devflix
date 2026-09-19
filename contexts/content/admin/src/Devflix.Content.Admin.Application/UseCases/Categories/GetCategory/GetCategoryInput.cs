using Devflix.Content.Admin.Application.UseCases.Categories.Common;

using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Categories.GetCategory;

public record GetCategoryInput(Guid Id) : IRequest<CategoryModelOutput>;