using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork1.Dados.Context;
using UnitOfWork1.Dados.Context.Entities;

namespace UnitOfWork1.Dados.Repositories.Articles
{
    public class ArticleRepository : IArticleRepository, IDisposable
    {
        private readonly ArticleContext articleContext;

        public ArticleRepository(ArticleContext articleContext)
        {
            this.articleContext = articleContext;
        }

        public IEnumerable<Article> Get()
        {
            return articleContext.Article;
        }

        public Article GetById(int articleId)
        {
            return articleContext
                    .Article
                    .Where(a => a.ArticleId.Equals(articleId));
        }

        public void Add(Article article)
        {
            articleContext.Article.Add(article);
        }

        public void Delete(int articleId)
        {
            var article = articleContext
                            .Article
                            .FirstOrDefault(a => a.ArticleId.Equals(articleId));
            articleContext.Article.Remove(article);
        }

        public void Dispose()
        {
            if (articleContext != null)
            {
                articleContext.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
