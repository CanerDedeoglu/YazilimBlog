﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazılımBlog.Entities.Dtos;

namespace YazılımBlog.Mvc.Areas.Admin.Models
{
    public class CategoryUpdateAjaxViewModel
    {
        public CategoryUpdateDto CategoryUpdateDto { get; set; }
        public string CategoryUpdatePartial { get; set; }
        public CategoryDto CategoryDto { get; set; }
    }
}
