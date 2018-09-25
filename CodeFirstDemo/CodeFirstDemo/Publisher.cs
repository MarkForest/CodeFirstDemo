using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Publisher
    {
        public Publisher()
        {

        }

        public int Id { get; set; }
        public string PublisherName { get; set; }
        public int CityId { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual City City { get; set; }

    }
}
