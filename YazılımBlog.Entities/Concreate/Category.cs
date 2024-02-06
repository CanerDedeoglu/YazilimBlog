using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Shared.Entities.Abstract;


namespace YazılımBlog.Entities.Concreate
{
	public class Category : EntityBase, IEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<Article> Articles { get; set; }
	}
}
