using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Data.Abstract;
using YazılımBlog.Data.Concrete.EntityFramework.Contexts;
using YazılımBlog.Entities.Concreate;
using YazılımBlog.Shared.Data.Concreate.EntityFramework;

namespace YazılımBlog.Data.Concreate.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await YazılımBlogContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }

        private YazılımBlogContext YazılımBlogContext
        {
            get
            {
                return _context as YazılımBlogContext;
            }
        }
    }
}
