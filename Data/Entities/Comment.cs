using System;

namespace AriBilgi.ArticleApp.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int ArticleId { get; set; }
        public DateTime dateTime { get; set; }

        public Article Article { get; set; }
    }
}
