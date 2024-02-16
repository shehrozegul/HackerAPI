using HackerNewsApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsApi.Domain.DomainModels
{
    public class Story : IEntity
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public string Uri { get; set; }
        public string PostedBy { get; set; }
        public int CommentCount { get; set; }
    }
}
