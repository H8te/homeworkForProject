using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Web.Data.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public List<Car> cars { set; get; }
    }
}
