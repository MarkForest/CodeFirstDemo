using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author { FirstName = "Isaac", LastName = "Azimov" };
            using (LibraryContext db = new LibraryContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
                foreach (var a in db.Authors)
                {
                    Console.WriteLine(a.FirstName+" "+a.LastName);
                }
            }
            Console.ReadKey();
        }
    }
}
