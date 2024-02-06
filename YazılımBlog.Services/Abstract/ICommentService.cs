﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Shared.Utilities.Results.Abstract;

namespace YazılımBlog.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<int>> Count();
        Task<IDataResult<int>> CountByIsDeleted();
    }
}
