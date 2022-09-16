using AriBilgi.ArticleApp.Data.Entities;
using AriBilgi.ArticleApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AriBilgi.ArticleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Comment> _commentRepo;
        private readonly IRepository<Article> _articleRepo;

        public HomeController(IRepository<Comment> commentRepo, IRepository<Article> articleRepo)
        {
            _commentRepo = commentRepo;
            _articleRepo = articleRepo;
        }

        public IActionResult Index()
        {
            return View(_articleRepo.GetAll());
        }
        public IActionResult TextDetail(int ArticleId)
        {
            Article article = _articleRepo.Get(x => x.Id == ArticleId);
            article.comments = _commentRepo.GetAll(x => x.ArticleId == ArticleId);
            return View(article);
        }
        public IActionResult AddComment(string CommentText, int ArticleId)
        {
            Comment comment = new();
            comment.ArticleId = ArticleId;
            comment.CommentText = CommentText;
            comment.dateTime = DateTime.Now;
            _commentRepo.Add(comment);
            return RedirectToAction("Index", "Home");
        }
    }
}
