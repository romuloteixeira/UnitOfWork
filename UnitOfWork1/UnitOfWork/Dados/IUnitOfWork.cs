using UnitOfWork1.Dados.Repositories.Articles;

namespace UnitOfWork1.Dados
{
    public interface IUnitOfWork
    {
        IArticleRepository ArticleRepository { get; }

        void Commit();
    }
}
