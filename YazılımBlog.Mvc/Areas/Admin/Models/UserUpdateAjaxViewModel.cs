﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazılımBlog.Entities.Dtos;

namespace YazılımBlog.Mvc.Areas.Admin.Models
{
    public class UserUpdateAjaxViewModel
    {
        public UserUpdateDto UserUpdateDto { get; set; }
        public string UserUpdatePartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
