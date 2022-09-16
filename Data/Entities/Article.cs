using System;
using System.Collections.Generic;

namespace AriBilgi.ArticleApp.Data.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime dateTime { get; set; }

        public List<Comment> comments { get; set; }
    }
}
