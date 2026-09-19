using Devflix.Content.Admin.Domain.Entities;
using Devflix.Content.Admin.Domain.SeedWork;
using Devflix.Content.Admin.Domain.SeedWork.SearcheableRepository;

namespace Devflix.Content.Admin.Domain.Repositories;

public interface IVideoRepository : IGenericRepository<Video>, ISearchableRepository<Video>
{
}