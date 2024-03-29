﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımBlog.Data.Abstract
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		IArticleRepository Articles { get; } // unitofwork.Articles
		ICategoryRepository Categories { get; }
		ICommentRepository Comments { get; }
		Task<int> SaveAsync();
	}
}
