using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Test2.DBContext;
using Test2.Models;

namespace Test2.Services
{
    public static class PatiantService
    {

        public static List<Patiant> GetPatiants()
        {
            using (var context = new TestContext())
            {

                return context.Patiants.Include(b => b.Title).ToList();

            }
        }
    }
}
