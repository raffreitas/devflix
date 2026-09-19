namespace Devflix.Content.Admin.Domain.Validations;

public abstract class ValidationHandler
{
    public abstract void HandleError(ValidationError validationError);
    public void HandleError(string message) => HandleError(new ValidationError(message));
}