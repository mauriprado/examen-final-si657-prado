using Recommendations.API.Shared.Persistence.Context;

namespace Recommendations.API.Shared.Persistence.Repositories;

public abstract class BaseRepository
{
    protected readonly AppDbContext Context;

    protected BaseRepository(AppDbContext context)
    {
        Context = context;
    }
}