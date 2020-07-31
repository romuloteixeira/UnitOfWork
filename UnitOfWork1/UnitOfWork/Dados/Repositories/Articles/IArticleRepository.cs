using System.Collections.Generic;
using UnitOfWork1.Dados.Context.Entities;

namespace UnitOfWork1.Dados.Repositories.Articles
{
    public interface IArticleRepository
    {
        void Add(Article article);
        void Delete(int articleId);
        IEnumerable<Article> Get();
        Article GetById(int articleId);
    }
}
