using EddyProject_Dao.Model_Login;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Dao.DataContext
{
    public class UserDAL : DbContext
    {
        public UserDAL() : base("name=DefaultConnection")
        {
        }

        public DbSet<User> users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            base.OnModelCreating(modelBuilder);
        }
    }
}
