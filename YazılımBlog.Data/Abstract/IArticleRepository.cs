using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Entities.Concreate;
using YazılımBlog.Shared.Data.Abstract;

namespace YazılımBlog.Data.Abstract
{
	public interface IArticleRepository : IEntityRepository<Article>
	{
	}
}
