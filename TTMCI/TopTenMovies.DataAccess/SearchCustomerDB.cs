﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using TopTenMovies.DataAccess;
using System.Linq;

namespace TopTenMovies.DataAccess
{
    public class SearchCustomerDB
    {
        public void SearchForCustomerDB(string firstName, string lastName)
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            //DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
            //    .UseSqlServer(connectionString)
            //    .Options;

            //using var context = new TopTenMoviesContext(options);

            //var foundName = context.Customer.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

            //if (foundName is null)
            //{
            //    Console.WriteLine("No Record Found");
            //    return;
            //}

            //Console.WriteLine($"\n[CustomerId] {foundName.CustomerId} [Customer Name] {foundName.FirstName} {foundName.LastName}");
        }
    }
}
