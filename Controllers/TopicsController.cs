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
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Design" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Food" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Movies" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Cars" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Series" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Games" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Netflix" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Playstation" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Microsoft" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "Github" },
                new TrendingTopics { CreationDate = DateTime.Now, HashtagTitle = "AI" },
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
