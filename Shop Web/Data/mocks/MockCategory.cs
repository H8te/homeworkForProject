using Shop_Web.Data.Interfaces;
using Shop_Web.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Web.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCatrgoties
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Электромобили", Description = "Современный вид транспорта" },
                    new Category { CategoryName = "Классические автомобили", Description = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
