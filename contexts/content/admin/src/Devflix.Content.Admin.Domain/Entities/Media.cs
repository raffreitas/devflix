using Devflix.Content.Admin.Domain.Enum;
using Devflix.Content.Admin.Domain.SeedWork;

namespace Devflix.Content.Admin.Domain.Entities;

public sealed class Media : Entity
{
    public string FilePath { get; private set; }
    public string? EncodedPath { get; private set; }
    public MediaStatus Status { get; private set; }

    public Media(string filePath)
    {
        FilePath = filePath;
        Status = MediaStatus.Pending;
    }

    public void UpdateSentToEncode() => Status = MediaStatus.Processing;

    public void UpdateAsEncodingError()
    {
        EncodedPath = null;
        Status = MediaStatus.Error;
    }

    public void UpdateAsEncoded(string encodedFilePath)
    {
        EncodedPath = encodedFilePath;
        Status = MediaStatus.Completed;
    }
}