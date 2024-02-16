using HackerNewsApi.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerNewsApi.Infrastructure.Repositories.StoryRepo
{
    public interface IHackerNewsRepository
    {
        Task<List<int>> GetBestStoryIdsAsync(int count);
        Task<List<Story>> GetStoriesByIdsAsync(List<int> storyIds);
        Task<Story> GetStoryByIdAsync(int storyId);
    }
}
