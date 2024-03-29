﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Shared.Utilities.Results.ComplexTpyes;

namespace YazılımBlog.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
    }
}
