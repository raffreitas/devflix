using FluentValidation;

namespace Devflix.Content.Admin.Application.UseCases.Categories.UpdateCategory;
public class UpdateCategoryInputValidator : AbstractValidator<UpdateCategoryInput>
{
    public UpdateCategoryInputValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();
    }
}
