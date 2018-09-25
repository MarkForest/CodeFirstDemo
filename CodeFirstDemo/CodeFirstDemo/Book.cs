using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Book
    {
        public Book()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> Pages { get; set; }
        public Nullable<int> Price { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }

    }
}
