using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.DBContext;
using Test2.Models;

namespace Test2.Services
{
    public static class TestService
    {
        public static List<Test> GetTests()
        {
            using (var context = new TestContext())
            {

                return context.Tests.ToList();

            }
        }

    }
}
