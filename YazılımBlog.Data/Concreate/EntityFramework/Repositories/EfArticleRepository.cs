using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Data.Abstract;
using YazılımBlog.Entities.Concreate;
using YazılımBlog.Shared.Data.Concreate.EntityFramework;

namespace YazılımBlog.Data.Concreate.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }

    }
}
