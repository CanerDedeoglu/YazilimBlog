using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımBlog.Entities.Concreate;
using YazılımBlog.Entities.Concrete;

namespace YazılımBlog.Data.Concreate.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");

            //builder.HasData(
            //    new Article
            //    {
            //        Id = 1,
            //        CategoryId = 1,
            //        Title = "C# 9.0 ve .NET 5 Yenilikleri",
            //        Content =
            //            "C# 9.0 ve .NET 5, 2020 yılının son çeyreğinde duyurulan ve 2021 yılında piyasaya sürülen en son sürümlerdir. Bu sürümler, C# ve .NET platformuna birçok yeni özellik ve iyileştirme getirdi." +
            //            "\r\n\r\nC# 9.0 Yenilikleri\r\n\r\nC# 9.0, aşağıdaki gibi birçok yeni özellik ve iyileştirme getirdi:" +
            //            "\r\n\r\nRecords: Records, sınıflara çok benzeyen, ancak bazı önemli farklılıkları olan veri yapılarıdır. Records, temel türlerden türetilebilir ve miras alabilir.\r\nToplu ifadeler: Toplu ifadeler, bir dizi işlemi tek bir ifadede yürütmenizi sağlayan yeni bir ifade türüdür.\r\nVarsayılan değerler: Metot parametreleri için varsayılan değerler tanımlamak için artık varsayılan değer operatörü (=>) kullanılabilir.\r\nDenetleyiciler: Denetleyiciler, bir nesnenin özelliklerini veya yöntemlerini değiştiren özel işlemlerdir. Denetleyiciler, artık bir nesnenin oluşturulması veya yok edilmesi sırasında çağrılabilir.\r\nİyileştirilmiş pattern matching: Pattern matching, bir nesnenin değerini veya türünü kontrol etmek için kullanılan bir yapıdır. C# 9.0, pattern matching'i daha güçlü ve kullanışlı hale getiren birçok iyileştirme getirdi.\r\n." +
            //            "NET 5 Yenilikleri\r\n\r\n.NET 5, aşağıdaki gibi birçok yeni özellik ve iyileştirme getirdi:" +
            //            "\r\n\r\nPlatform bağımsızlık: .NET 5, Windows, macOS, Linux, iOS, Android ve Web platformlarında çalışan tek bir uygulama geliştirme platformudur.\r\nYeni API'ler: .NET 5, yeni API'ler ve özellikler ekledi.\r\nPerformans iyileştirmeleri: .NET 5, performansı iyileştirmek için birçok iyileştirme yaptı.",

            //        Thumbnail = "Default.jpg",
            //        SeoDescription = "C# 9.0 ve .NET 5 Yenilikleri",
            //        SeoTags = "C#, C# 9, .NET5, .NET Framework, .NET Core",
            //        SeoAuthor = "Caner Dedeoğlu",
            //        Date = DateTime.Now,
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "C# 9.0 ve .NET 5 Yenilikleri",
            //        UserId = 1,
            //        ViewsCount = 100,
            //        CommentCount = 1
            //    },
            //    new Article
            //    {
            //        Id = 2,
            //        CategoryId = 2,
            //        Title = "C++ 11 ve 19 Yenilikleri",
            //        Content =
            //            "C++ 11 Yenilikleri\r\n\r\nC++ 11, aşağıdaki gibi birçok yeni özellik ve iyileştirme getirmiştir:" +
            //            "\r\n\r\nLambda ifadeleri: Lambda ifadeleri, kısa ve öz fonksiyonlar yazmak için kullanılan bir yapıdır." +
            //            "C++ 19, aşağıdaki gibi birçok yeni özellik ve iyileştirme getirmiştir:" +
            //            "Denetleyiciler: Denetleyiciler, bir nesnenin özelliklerini veya yöntemlerini değiştiren özel işlemlerdir. C++ 19, denetleyicileri daha güçlü ve kullanışlı hale getiren birçok iyileştirme getirmiştir." +
            //            "Düzenleyiciler: Düzenleyiciler, bir nesnenin özelliklerini veya yöntemlerini otomatik olarak güncelleyen bir yapıdır. C++ 19, düzenleyicileri destekleyen yeni bir std::optional sınıfı eklemiştir." +
            //            "Konsantrasyon ifadeleri: Konsantrasyon ifadeleri, bir nesneyi veya değişkeni bir değişkenin değerine bağlamak için kullanılan bir yapıdır. C++ 19, konsantrasyon ifadelerini destekleyen yeni bir std::move işlevi eklemiştir." +
            //            "Güçlü referanslar: Güçlü referanslar, bir nesneyi veya değişkeni başka bir nesneye veya değişkene bağlamak için kullanılan bir yapıdır. C++ 19, güçlü referansları destekleyen yeni bir std::weak_ptr sınıfı eklemiştir." +
            //            " ",
            //        Thumbnail = "Default.jpg",
            //        SeoDescription = "C++ 11 ve 19 Yenilikleri",
            //        SeoTags = "C++ 11 ve 19 Yenilikleri",
            //        SeoAuthor = "Caner Dedeoğlu",
            //        Date = DateTime.Now,
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "C++ 11 ve 19 Yenilikleri",
            //        UserId = 1,
            //        ViewsCount = 295,
            //        CommentCount = 1
            //    },
            //    new Article
            //    {
            //        Id = 3,
            //        CategoryId = 3,
            //        Title = "JavaScript ES2019 ve ES2020 Yenilikleri",
            //        Content =
            //            "\r\nJavaScript ES2019 ve ES2020 Yenilikleri" +
            //            "Array.from() ve Array.of() yöntemleri: Bir dizi oluşturmak için daha kolay ve esnek yollar sunar." +
            //            "OptionalChaining ve Nullish Coalescing Operator özellikleri: Bir nesnenin değerinin var olup olmadığını kontrol etmek için daha kolay yollar sunar." +
            //            "Type Inference özelliği: Değişkenlerin ve ifadelerin türlerinin otomatik olarak belirlenmesini sağlar." +
            //            "async/await özelliği: async fonksiyonları daha okunaklı ve anlaşılır hale getirir" +
            //            "Özet\r\n\r\n" +
            //            "ES2019 ve ES2020, JavaScript'e birçok yeni özellik ve iyileştirme getirdi. Bu yenilikler, JavaScript'i daha güçlü, esnek ve okunaklı hale getiriyor.",
            //        Thumbnail = "Default.jpg",
            //        SeoDescription = "JavaScript ES2019 ve ES2020 Yenilikleri",
            //        SeoTags = "JavaScript ES2019 ve ES2020 Yenilikleri",
            //        SeoAuthor = "Caner Dedeoğlu",
            //        Date = DateTime.Now,
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "JavaScript ES2019 ve ES2020 Yenilikleri",
            //        UserId = 1,
            //        ViewsCount = 12,
            //        CommentCount = 1
            //    }
            //);
        }
    }
}
