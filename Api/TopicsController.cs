using Microsoft.AspNetCore.Mvc;
using ForumWars.Data;

namespace ForumWars.Api
{
    public class TopicsController : Controller
    {
        public TopicsController()
        {

        }

        public async Task<List<Topic>> GetTopicList()
        {
            return new List<Topic>
            {
                new Topic
                {
                    Title = "Why start with NextJS ?",
                    UpVotes = 84,
                    TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CommunityTopics = new List<string>{ "Development", "React", "Next"}
                },
                new Topic
                {
                    Title = "Invincible Season 2",
                    TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    UpVotes = 45,
                    CommunityTopics = new List<string>{ "Streaming", "Netflix" }
                },
                new Topic
                {
                    Title = ".NET Blazor Server",
                    TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CommunityTopics = new List<string>{ ".NET", ".NET Core" },
                    UpVotes = 32,
                },
                new Topic
                {
                    Title = "New Salmon Receipt!",
                    TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CommunityTopics = new List<string>{ "Food", "Cooking", "Kitchen"},
                    UpVotes = 25,
                },
                new Topic
                {
                    Title = "Leet Code - A New Way To Prepare Yourself",
                    TopicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CommunityTopics = new List<string>{ "Development", "LeetCode" },
                    UpVotes = 8,

                }
            };
        }
    }
}
