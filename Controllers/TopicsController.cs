using ForumWars.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ForumWars.Controllers
{
    public class TopicsController : Controller
    {
        #region Properties
        private readonly List<TrendingTopics> trendingTopicsList = new List<TrendingTopics>
            {
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "News" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Games" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "World" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Movies" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Comedy" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Development" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Netflix" },                                                
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Microsoft" },                
            };        
        #endregion

        #region Constructors
        public TopicsController()
        {

        }
        #endregion

        #region Methods
        public Task<List<TrendingTopics>> GetTrendingTopics()
        {
            return Task.FromResult(trendingTopicsList);
        }        
        #endregion
    }
}
