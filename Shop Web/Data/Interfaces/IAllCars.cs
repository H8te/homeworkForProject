﻿using Shop_Web.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Web.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars {get; }
        IEnumerable<Car> getFavoriteCars { set; get; }
        Car getObjectCar(int carId);
    }
}
