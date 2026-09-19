namespace Devflix.Content.Admin.Domain.Validations;

public abstract class Validator(ValidationHandler handler)
{
    protected ValidationHandler _handler = handler;

    public abstract void Validate();
}