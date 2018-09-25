using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class City
    {
        public City()
        {

        }
        public int Id { get; set; }
        public string CityName { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
    }
}
