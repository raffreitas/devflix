using Devflix.Content.Admin.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Devflix.Content.Admin.Infra.Data.EF.Configurations;

internal sealed class MediaConfiguration : IEntityTypeConfiguration<Media>
{
    public void Configure(EntityTypeBuilder<Media> builder)
    {
        builder.Property(media => media.Id).ValueGeneratedNever();
    }
}