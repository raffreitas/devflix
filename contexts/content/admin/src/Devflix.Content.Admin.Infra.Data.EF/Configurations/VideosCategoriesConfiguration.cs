using Devflix.Content.Admin.Infra.Data.EF.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Devflix.Content.Admin.Infra.Data.EF.Configurations;

internal class VideosCategoriesConfiguration : IEntityTypeConfiguration<VideosCategories>
{
    public void Configure(EntityTypeBuilder<VideosCategories> builder)
        => builder.HasKey(relation => new { relation.CategoryId, relation.VideoId });
}