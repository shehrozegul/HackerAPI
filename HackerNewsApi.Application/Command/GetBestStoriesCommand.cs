using HackerNewsApi.Domain.DomainModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsApi.Application.Command
{
    public class GetBestStoriesCommand : IRequest<List<Story>>
    {
        public int Count { get; }

        public GetBestStoriesCommand(int count)
        {
            Count = count;
        }
    }

}
