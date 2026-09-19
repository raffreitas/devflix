using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.Categories.DeleteCategory;
public record DeleteCategoryInput(Guid Id) : IRequest;
