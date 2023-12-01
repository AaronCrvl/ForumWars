﻿namespace ForumWars.Data
{
    public class Topic
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string? TopicText { get; set; }
        public List<string>? CommunityTopics { get; set; }
        public int UpVotes { get; set; }
    }
}
