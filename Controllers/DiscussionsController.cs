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
                CreationDate = new DateTime(2023, 11, 05, 08, 20, 32, DateTimeKind.Local),
                Title = "Comedy Shows In Your Town",
                UpVotes = 541,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Comedy", "StandUp" }
            },
            new Discussion
            {
                Id = 1,
                Author = "77SupraRider",
                CreationDate = new DateTime(2023, 12, 25, 12, 0, 32, DateTimeKind.Local),
                Title = "Best vehicles on offroad category",
                UpVotes = 155,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Cars", "Vehicles" }
            },
            new Discussion
            {
                Id = 2,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 08, 06, 15, 45, 02, DateTimeKind.Local),
                Title = "Why start with NextJS ?",
                UpVotes = 115,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Development", "React", "Next"}
            },
            new Discussion
            {
                Id = 3,
                Author = "__AnotherAlien",
                CreationDate = new DateTime(2023, 12, 12, 08, 12, 27, DateTimeKind.Local),
                Title = "Invincible Season 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                UpVotes = 189,
                CommunityTopics = new List<string>{ "Streaming", "Netflix" }
            },
            new Discussion
            {
                Id = 4,
                Author = "StupidDreams",
                CreationDate = new DateTime(2023, 11, 29, 01, 15, 07, DateTimeKind.Local),
                Title = ".NET Blazor Server",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ ".NET", ".NET Core" },
                UpVotes = 32,
            },
            new Discussion
            {
                Id = 5,
                Author = "Katie__AA5556",
                CreationDate = new DateTime(2023, 12, 29, 20, 35, 00, DateTimeKind.Local),
                Title = "Cooking for myself, a great experience!",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Food", "Cooking" },
                UpVotes = 200,
            },
            new Discussion
            {
                Id = 6,
                Author = "user415522",
                CreationDate = new DateTime(2023, 12, 20, 07, 55, 37, DateTimeKind.Local),
                Title = "New Salmon Receipt!",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Food", "Cooking", "Kitchen"},
                UpVotes = 98,
            },
            new Discussion
            {
                Id = 7,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 12, 17, 21, 15, 00, DateTimeKind.Local),
                Title = "Leet Code - A New Way To Prepare Yourself",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Development", "LeetCode" },
                UpVotes = 35,
            },
            new Discussion
            {
                Id = 8,
                Author = "MudBoy",
                CreationDate = new DateTime(2023, 12, 29, 20, 35, 00, DateTimeKind.Local),
                Title = "How long we'll wait until GTA VI drop?",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Games", "GTAVI" },
                UpVotes = 156,
            },
            new Discussion
            {
                Id = 9,
                Author = "Ratzzzzzz",
                CreationDate = new DateTime(2023, 12, 29, 20, 35, 00, DateTimeKind.Local),
                Title = "Global Temparature Warning",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Health", "Global", "News", "World" },
                UpVotes = 213,
            },
            new Discussion
            {
                Id = 10,
                Author = "TwidyLongWay_444444",
                CreationDate = new DateTime(2023, 12, 10, 11, 20, 05, DateTimeKind.Local),
                Title = "Best Movies To Watch In 2023",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Movies", "Cinema" },
                UpVotes = 344,
            },
            new Discussion
            {
                Id = 11,
                Author = "Ratzzzzzz",
                CreationDate = new DateTime(2023, 12, 29, 20, 35, 00, DateTimeKind.Local),
                Title = "WW3 is here?",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "War", "Global", "News", "World" },
                UpVotes = 422,
            },
            new Discussion
            {
                Id = 12,
                Author = "444pGameboy",
                CreationDate = new DateTime(2023, 12, 02, 19, 35, 00, DateTimeKind.Local),
                Title = "The Minecraft Franchise - All Games",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Games", "Minecraft"},
                UpVotes = 210,
            },
            new Discussion
            {
                Id = 13,
                Author = "MadRaza",
                CreationDate = new DateTime(2023, 12, 10, 20, 11, 00, DateTimeKind.Local),
                Title = "Watch Dogs - Cyberpsycho",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Games", "Release"},
                UpVotes = 440,
            },
            new Discussion
            {
                Id = 14,
                Author = "444pGameboy",
                CreationDate = new DateTime(2023, 12, 29, 20, 46, 00, DateTimeKind.Local),
                Title = "Resindent Evil Team Next Move",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Games" },
                UpVotes = 548,
            },
            new Discussion
            {
                Id = 15,
                Author = "GlobalNww",
                CreationDate = new DateTime(2023, 12, 29, 20, 46, 00, DateTimeKind.Local),
                Title = "ASpecies at Risk of Extinction",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "News", "Nature" },
                UpVotes = 266,
            },
            new Discussion
            {
                Id = 16,
                Author = "GlobalNww",
                CreationDate = new DateTime(2023, 12, 29, 20, 46, 00, DateTimeKind.Local),
                Title = "Global Warming - Update",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Games" },
                UpVotes = 548,
            },
            new Discussion
            {
                Id = 17,
                Author = "444pGameboy",
                CreationDate = new DateTime(2023, 12, 29, 20, 46, 00, DateTimeKind.Local),
                Title = "Resindent Evil Team Next Move",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Games" },
                UpVotes = 301,
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

            if (typedText != null && typedText.Length > 3)
                finalList =
                    finalList
                    .Where(x => x.Title.Contains(typedText) || (x.CommunityTopics != null && x.CommunityTopics.Contains(typedText)))
                    .ToList<Discussion>();

            if (upvotes > 0)
                finalList = finalList.Where(x => x.UpVotes >= upvotes).ToList();

            if (DateTime.Compare(initialDate, default(DateTime)) > 0) // if initial date is later then new DateTime
                finalList = finalList.Where(x => x.CreationDate >= initialDate).ToList();

            if (DateTime.Compare(finalDate, default(DateTime)) > 0) // if final date is later then new DateTime
                finalList = finalList.Where(x => x.CreationDate <= finalDate).ToList();

            return Task.FromResult(finalList);
        }

        public Task<Discussion> GetDiscussion(int idTopic)
        {
            Task.Delay(2000); // latência de 2 segundos
            return Task.FromResult(this._discussions[idTopic]);
        }

        public Task<List<Comment>> GetDiscussionComments(int topicId)
        {
            Task.Delay(2000); // latência de 2 segundos
            return Task.FromResult(this._comments);
        }

        public Task<List<Discussion>> GetRelatedDiscussions(string topic)
        {
            // latency
            Task.Delay(2000);

            // Only discussions with Community Topics
            var list = this._discussions;
            list = list.Where(x => x.CommunityTopics != null).ToList();

            // Only discussions with related Community Topics
            if (list.Where(x => x.CommunityTopics.Contains(topic)).Count() > 0)
                return Task.FromResult(list.Where(x => x.CommunityTopics.Contains(topic) || x.Title.Contains(topic)).ToList());
            else
                return Task.FromResult(new List<Discussion>());
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
