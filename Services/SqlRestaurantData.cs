﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhidhaLagche.Data;
using KhidhaLagche.Models;
using Microsoft.EntityFrameworkCore;

namespace KhidhaLagche.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private KhidaLagcheDbContext _context;

        public SqlRestaurantData(KhidaLagcheDbContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            _context.Restaurants.Add(newRestaurant);
            _context.SaveChanges();

            return newRestaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = EntityState.Modified;
            _context.SaveChanges();

            return restaurant;
        }
    }
}
