using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork1.Dados.Context;
using UnitOfWork1.Dados.Repositories.Articles;

namespace UnitOfWork1.Dados
{
    public class UnitOfWork : IUnitOfWork
    {
        private IArticleRepository articleRepository;
        private readonly ArticleContext articleContext;

        public UnitOfWork(ArticleContext articleContext)
        {
            this.articleContext = articleContext;
        }

        public IArticleRepository ArticleRepository
        {
            get
            {
                if (articleRepository is null)
                {
                    articleRepository = new ArticleRepository(articleContext);
                }

                return articleRepository;
            }
        }

        public void Commit()
        {
            articleContext.SaveChanges();
        }
    }
}
