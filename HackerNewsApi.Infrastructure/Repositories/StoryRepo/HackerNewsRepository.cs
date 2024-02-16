using HackerNewsApi.Domain.DomainModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsApi.Infrastructure.Repositories.StoryRepo
{
    public class HackerNewsRepository : IHackerNewsRepository
    {
        private readonly HttpClient _httpClient;

        public HackerNewsRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<int>> GetBestStoryIdsAsync(int count)
        {
            var response = await _httpClient.GetStringAsync("https://hacker-news.firebaseio.com/v0/beststories.json");
            var bestStoryIds = JsonConvert.DeserializeObject<List<int>>(response);
            return bestStoryIds.Take(count).ToList();
        }

        public async Task<List<Story>> GetStoriesByIdsAsync(List<int> storyIds)
        {
            var tasks = storyIds.Select(id => GetStoryByIdAsync(id));
            return (await Task.WhenAll(tasks)).ToList();
        }

        public async Task<Story> GetStoryByIdAsync(int storyId)
        {
            var response = await _httpClient.GetStringAsync($"https://hacker-news.firebaseio.com/v0/item/{storyId}.json");
            return JsonConvert.DeserializeObject<Story>(response);
        }
    }
}
