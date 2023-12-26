using Microsoft.AspNetCore.Mvc;
using ForumWars.Data;
using System.Linq;

namespace ForumWars.Controllers
{
    public class TopicsController : Controller
    {
        #region Propeties
        private Random gen = new Random();
        private List<Topic> _topics = new List<Topic>
        {
             new Topic
            {
                Id = 0,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 12, 25),
                Title = "Comedy Shows",
                UpVotes = 55,
                TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Comedy", "StandUp" }
            },
            new Topic
            {
                Id = 1,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 08, 06),
                Title = "Why start with NextJS ?",
                UpVotes = 84,
                TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Development", "React", "Next"}
            },
            new Topic
            {
                Id = 2,
                Author = "__AnotherAlien",
                CreationDate = new DateTime(2023, 12, 12),
                Title = "Invincible Season 2",
                TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                UpVotes = 45,
                CommunityTopics = new List<string>{ "Streaming", "Netflix" }
            },
            new Topic
            {
                Id = 3,
                Author = "StupidDreams",
                CreationDate = new DateTime(2023, 11, 29),
                Title = ".NET Blazor Server",
                TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ ".NET", ".NET Core" },
                UpVotes = 32,
            },
            new Topic
            {
                Id = 4,
                Author = "user415522",
                CreationDate = new DateTime(2023, 12, 20),
                Title = "New Salmon Receipt!",
                TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Food", "Cooking", "Kitchen"},
                UpVotes = 25,
            },
            new Topic
            {
                Id = 5,
                Author = "MikeDice24555",
                CreationDate = new DateTime(2023, 12, 17),
                Title = "Leet Code - A New Way To Prepare Yourself",
                TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CommunityTopics = new List<string>{ "Development", "LeetCode" },
                UpVotes = 8,
            }
        };
        #endregion

        #region Constructors
        public TopicsController()
        {

        }
        #endregion

        #region Methods
        public Task<List<Topic>> GetTopicList(int qtd = 0)
        {
            Task.Delay(2000); // 2 seconds latency            
            return Task.FromResult(qtd > 0 ? _topics.Take(qtd).ToList() : _topics);
        }

        public Task<List<Topic>> SearchInTopicList(string? typedText = "", int? upvotes = 0, DateTime initialDate = new DateTime(), DateTime finalDate = new DateTime())
        {
            Task.Delay(2000); // 2 seconds latency   
            var finalList = _topics;

            if (typedText != null && typedText.Length > 0)
                finalList = finalList.Where(x => x.Title.Contains(typedText) == true).ToList<Topic>();

            if (upvotes > 0)
                finalList = finalList.Where(x => x.UpVotes >= upvotes).ToList();

            if (initialDate != new DateTime())
                finalList = finalList.Where(x => x.CreationDate >= initialDate).ToList();

            if (initialDate != new DateTime())
                finalList = finalList.Where(x => x.CreationDate <= finalDate).ToList();            

            return Task.FromResult(finalList);
        }

        public Task<Topic> GetTopic(int idTopic)
        {
            Task.Delay(2000); // latência de 2 segundos
            return Task.FromResult(idTopic switch
            {
                0 => _topics[0],
                1 => _topics[1],
                2 => _topics[2],
                3 => _topics[3],
                4 => _topics[4],
                5 => _topics[5],
                _ => new Topic
                {
                    Title = "The default topic",
                    TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CommunityTopics = new List<string> { "Default", "Default", "Default", "Default" },
                    UpVotes = 8,

                },
            });
        }

        public Task<List<Comment>> GetTopicComments(int topicId)
        {
            Task.Delay(2000); // latência de 2 segundos
            return Task.FromResult(new List<Comment>
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
                    UserId  = 75454,
                    Username = "MicroMan",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                },
                new Comment
                {
                    UserId  = 7777,
                    Username = "CuteMonkey",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                },
                new Comment
                {
                    UserId  = 24423,
                    Username = "Unknown",
                    CommentText = "This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544 This is a test comment. 545545445544",
                    CreatedDate = RandomDay(),
                }
            });
        }

        /*
         * For better performance if this will be called repeatedly, 
         * create the start and gen (and maybe even range) variables 
         * outside of the function.
         */
        private DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        #endregion              
    }
}
