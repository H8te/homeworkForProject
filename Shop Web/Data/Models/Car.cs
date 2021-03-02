using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Web.Data.Models
{
    public class Car
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string ShortDescription { set; get; }
        public string LongDescription { set; get; }
        public string Image { set; get; }
        public ushort Price { set; get; }
        public bool IsFavorite { set; get; }
        public bool Aviliable { set; get; }
        public int CategoryId { set; get; }

        public virtual Category Category { set; get; }
    }
}
