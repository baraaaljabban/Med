using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.DBContext;
using Test2.Models;

namespace Test2.Services
{
    public static class DoctorService
    {
        public static List<Doctor> GetDoctors()
        {
            using (var context = new TestContext())
            {

                return context.Doctors.ToList();

            }
        }
    }
}
