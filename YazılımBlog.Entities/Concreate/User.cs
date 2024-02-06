using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using YazılımBlog.Entities.Concreate;

namespace YazılımBlog.Entities.Concrete
{
    public class User : IdentityUser<int>
    {
        public string Picture { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
