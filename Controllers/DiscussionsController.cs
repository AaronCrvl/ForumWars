using Microsoft.AspNetCore.Mvc;
using ForumWars.Data;
using System.Linq;

namespace ForumWars.Controllers
{
    public class DiscussionsController : Controller
    {
        #region Propeties        
        private readonly List<Discussion> _discussions = new List<Discussion>
        {
             new Discussion
            {
                Id = 0,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 12, 25, 12, 0, 32, DateTimeKind.Local),
                Title = "Comedy Shows",
                UpVotes = 55,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Comedy", "StandUp" }
            },
            new Discussion
            {
                Id = 1,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 08, 06, 15, 45, 02, DateTimeKind.Local),
                Title = "Why start with NextJS ?",
                UpVotes = 84,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Development", "React", "Next"}
            },
            new Discussion
            {
                Id = 2,
                Author = "__AnotherAlien",
                CreationDate = new DateTime(2023, 12, 12, 08, 12, 27, DateTimeKind.Local),
                Title = "Invincible Season 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                UpVotes = 45,
                CommunityTopics = new List<string>{ "Streaming", "Netflix" }
            },
            new Discussion
            {
                Id = 3,
                Author = "StupidDreams",
                CreationDate = new DateTime(2023, 11, 29, 01, 15, 07, DateTimeKind.Local),
                Title = ".NET Blazor Server",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ ".NET", ".NET Core" },
                UpVotes = 32,
            },
            new Discussion
            {
                Id = 4,
                Author = "user415522",
                CreationDate = new DateTime(2023, 12, 20, 07, 55, 37, DateTimeKind.Local),
                Title = "New Salmon Receipt!",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Food", "Cooking", "Kitchen"},
                UpVotes = 25,
            },
            new Discussion
            {
                Id = 5,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 12, 17, 21, 15, 00, DateTimeKind.Local),
                Title = "Leet Code - A New Way To Prepare Yourself",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Development", "LeetCode" },
                UpVotes = 8,
            }
        };
        private readonly List<Comment> _comments = new List<Comment>
            {
                new Comment
                {
                    UserId  = 453469,
                    Username = "MicroMan",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                },
                new Comment
                {
                    UserId  = 14645,
                    Username = "ISSSSP",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                },
                new Comment
                {
                    UserId = 75454,
                    Username = "MicroMan",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                },
                new Comment
                {
                    UserId = 7777,
                    Username = "CuteMonkey",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                },
                new Comment
                {
                    UserId = 24423,
                    Username = "Unknown",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                },
            };
        #endregion

        #region Constructors
        public DiscussionsController()
        {

        }
        #endregion

        #region Methods
        public Task<List<Discussion>> GetDiscussionList(int qtd = 0)
        {
            Task.Delay(2000); // 2 seconds latency            
            return Task.FromResult(qtd > 0 ? _discussions.Take(qtd).ToList() : _discussions);
        }

        public Task<List<Discussion>> SearchInDiscussionList(string? typedText = "", int? upvotes = 0, DateTime initialDate = new DateTime(), DateTime finalDate = new DateTime())
        {
            Task.Delay(2000); // 2 seconds latency   
            var finalList = _discussions;

            if (typedText != null && typedText.Length > 0)
                finalList = finalList.Where(x => x.Title.Contains(typedText)).ToList<Discussion>();

            if (upvotes > 0)
                finalList = finalList.Where(x => x.UpVotes >= upvotes).ToList();

            if (DateTime.Compare(initialDate, DateTime.Parse("0001-01-01T1200:00:00")) > 0) // if initial date is later then new DateTime
                finalList = finalList.Where(x => x.CreationDate >= initialDate).ToList();

            if (DateTime.Compare(finalDate, DateTime.Parse("0001-01-01T1200:00:00")) > 0) // if final date is later then new DateTime
                finalList = finalList.Where(x => x.CreationDate <= finalDate).ToList();

            return Task.FromResult(finalList);
        }

        public Task<Discussion> GetDiscussion(int idTopic)
        {
            Task.Delay(2000); // latência de 2 segundos
            return Task.FromResult(idTopic switch
            {
                0 => _discussions[0],
                1 => _discussions[1],
                2 => _discussions[2],
                3 => _discussions[3],
                4 => _discussions[4],
                5 => _discussions[5],
                _ => new Discussion
                {
                    Title = "The default topic",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CommunityTopics = new List<string> { "Default", "Default", "Default", "Default" },
                    UpVotes = 8,

                },
            });
        }

        public Task<List<Comment>> GetDiscussionComments(int topicId)
        {
            Task.Delay(2000); // latência de 2 segundos
            return Task.FromResult(_comments);
        }

        public Task<List<Discussion>> GetRelatedDiscussions(string topic)
        {
            // latency
            Task.Delay(2000);

            // Only discussions with Community Topics
            var list = _discussions.Where(x => x.CommunityTopics != null).ToList();

            // Only discussions with related Community Topics
            if (list.Where(x => x.CommunityTopics!.Contains(topic)).Count() > 0)
                list = list.Where(x => x.CommunityTopics!.Contains(topic)).ToList();
            else // if the filter dont exist bring discussions with the topic on the title os description.
                list = list.Where(x => x.Title.Contains(topic) || x.Description.Contains(topic)).ToList();

            return Task.FromResult(list);
        }

        /*
         * For better performance if this will be called repeatedly, 
         * create the start and gen (and maybe even range) variables 
         * outside of the function.
         */
        private static DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        #endregion              
    }
}
