using Devflix.Content.Admin.Application.Common;

using FluentAssertions;

namespace Devflix.Content.Admin.UnitTests.Application.Common;

[Trait("Application", "StorageName - Common")]
public sealed class StorageFileNameTest
{
    [Fact]
    public void CreateStorageNameForFile()
    {
        var exampleId = Guid.NewGuid();
        const string exampleExtension = "mp4";
        const string propertyName = "Video";

        var name = StorageFileName.Create(exampleId, propertyName, exampleExtension);

        name.Should().Be($"{exampleId}/{propertyName.ToLower()}.{exampleExtension}");
    }
}