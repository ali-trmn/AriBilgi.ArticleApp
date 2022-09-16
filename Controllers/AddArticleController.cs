using AriBilgi.ArticleApp.Data.Entities;
using AriBilgi.ArticleApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AriBilgi.ArticleApp.Controllers
{
    public class AddArticleController : Controller
    {
        private readonly IRepository<Article> _articleRepo;

        public AddArticleController(IRepository<Article> articleRepo)
        {
            _articleRepo = articleRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddText(Article article)
        {
            article.dateTime = DateTime.Now;
            _articleRepo.Add(article);
            return RedirectToAction("Index", "Home");
        }
    }
}
