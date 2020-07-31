using Microsoft.EntityFrameworkCore;
using UnitOfWork1.Dados.Context.Entities;

namespace UnitOfWork1.Dados.Context
{
    public class ArticleContext : DbContext
    {
        //static ArticleContext()
        //{
        //    Database
        //        .SetInitializer<ArticleContext>(new ContextInitialize());
        //}

        public ArticleContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}
