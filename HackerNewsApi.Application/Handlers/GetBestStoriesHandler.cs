using HackerNewsApi.Application.Command;
using HackerNewsApi.Domain.DomainModels;
using HackerNewsApi.Infrastructure.Repositories.StoryRepo;
using MediatR;

namespace HackerNewsApi.Application.Handlers
{
    public class GetBestStoriesHandler : IRequestHandler<GetBestStoriesCommand, List<Story>>
    {
        private readonly IHackerNewsRepository _repository;

        public GetBestStoriesHandler(IHackerNewsRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Story>> Handle(GetBestStoriesCommand request, CancellationToken cancellationToken)
        {
            var bestStoryIds = await _repository.GetBestStoryIdsAsync(request.Count);
            var bestStories = await _repository.GetStoriesByIdsAsync(bestStoryIds);

            return bestStories.OrderByDescending(s => s.Score).ToList();
        }
    }
}
