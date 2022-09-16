using AriBilgi.ArticleApp.Data.Entities;
using AriBilgi.ArticleApp.Data.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AriBilgi.ArticleApp.TagHelpers
{
    [HtmlTargetElement("getShortText")]
    public class ShortText : TagHelper
    {
        public int ApplicationUserIdHtml { get; set; }
        private readonly IRepository<Article> _articleRepo;

        public ShortText(IRepository<Article> articleRepo)
        {
            _articleRepo = articleRepo;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            Article article = new();
            article = _articleRepo.Get(x => x.Id == ApplicationUserIdHtml);
            var shortText = article.Text.Substring(0, 250);
            output.Content.SetHtmlContent(shortText);
        }
    }
}
