namespace ForumWars.Data
{
    public class Comment
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? CommentText { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.MinValue;
    }
}