using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Test2.DBContext;
using Test2.Models;

namespace Test2.Services
{
    public static class SettingService
    {

        public static Setting LoadSettings()
        {
            using (var context = new TestContext())
            {

                return context.Settings.Include(b => b.Unit).First();

            }
        }
        
    }
}
