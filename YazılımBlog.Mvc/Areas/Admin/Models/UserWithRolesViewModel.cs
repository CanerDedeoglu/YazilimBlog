using System.Collections.Generic;
using YazılımBlog.Entities.Concrete;

namespace YazılımBlog.Mvc.Areas.Admin.Models
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
