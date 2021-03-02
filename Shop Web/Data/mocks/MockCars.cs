using Shop_Web.Data.Interfaces;
using Shop_Web.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Web.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        LongDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "/img/tesla2.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Aviliable = true,
                        Category = _categoryCars.AllCatrgoties.First()
                    },
                    new Car
                    {
                        Name = "BWM M5",
                        ShortDescription = "Стильный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/bmw.jpg",
                        Price = 65000,
                        IsFavorite = true,
                        Aviliable = true,
                        Category = _categoryCars.AllCatrgoties.Last(),
                    }                                                      
                };
            }
        }

        public IEnumerable<Car> getFavoriteCars { get; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
