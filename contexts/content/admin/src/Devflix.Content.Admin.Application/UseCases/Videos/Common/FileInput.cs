namespace Devflix.Content.Admin.Application.UseCases.Videos.Common;

public sealed record FileInput(string Extension, Stream FileStream, string ContentType);