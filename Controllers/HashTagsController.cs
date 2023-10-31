﻿using ForumWars.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ForumWars.Controllers
{
    public class HashTagsController : Controller
    {

        public HashTagsController()
        {

        }

        public Task<List<TrendingHastag>> GetHashtags()
        {        
            return Task.FromResult(new List<TrendingHastag>
            {
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Design" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Food" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Movies" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Cars" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Series" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Games" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Netflix" },                
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Playstation" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Microsoft" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "Github" },
                new TrendingHastag { CreationDate = DateTime.Now, HashtagTitle = "AI" },
            });
        }
    }
}