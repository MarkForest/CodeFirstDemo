using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemo
{
    public class LibraryContext: DbContext
    {
        public LibraryContext()
            :base("MyConnectionString")
        {
            //инициализаторы для режима работы entity  
            //создает новую базу всегда
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseAlways<LibraryContext>());
            //создает биби если она изменилась
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseIfModelChanges<LibraryContext>());
            //создает биби если ее нет
           // Database.SetInitializer<LibraryContext>(new CreateDatabaseIfNotExists<LibraryContext>());
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<City> City { get; set; }
    }
}
