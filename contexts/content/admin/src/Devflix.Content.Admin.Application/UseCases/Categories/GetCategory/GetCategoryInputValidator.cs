using FluentValidation;

namespace Devflix.Content.Admin.Application.UseCases.Categories.GetCategory;
public class GetCategoryInputValidator : AbstractValidator<GetCategoryInput>
{
    public GetCategoryInputValidator()
        => RuleFor(x => x.Id).NotEmpty();
}