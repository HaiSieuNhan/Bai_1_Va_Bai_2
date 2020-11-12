using Microsoft.EntityFrameworkCore;
using test_VersionDb.Entities;

namespace EcommerceDb
{
    public class test_VersionDbContext:DbContext
    {
        //Hàm tạo để kết nối vs database
        public test_VersionDbContext(DbContextOptions<test_VersionDbContext> options) : base(options)
        {

        }
      
        public DbSet<test_Version> test_Versions { get; set; }

    }
}
