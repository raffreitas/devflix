using MediatR;

namespace Devflix.Content.Catalog.Application.UseCases.Categories.DeleteCategory;
public record DeleteCategoryInput(Guid Id) : IRequest;
