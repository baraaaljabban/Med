using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Test2.DBContext;

namespace Test2.Models
{
    public class Patiant
    {
        [Key]
        public int PatiantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public Title Title { get; set; }
        public string Phome { get; set; }
        public string Moblie { get; set; }
        public string Mail { get; set; }
        public DateTime BirthDay { get; set; }

        public void Add()
        {
            using (var context = new TestContext())
            {

                context.Patiants.Add(this);
                context.SaveChanges();

            }
        }

        public void Edit()
        {

            using (var context = new TestContext())
            {

                context.Entry(this).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void Delete()
        {
            using (var context = new TestContext())
            {

                context.Entry(this).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public bool Reload()
        {
            try
            {
                using (var context = new TestContext())
                {
                    context.Entry(this).Reload();
                    return true;
                }
                
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
