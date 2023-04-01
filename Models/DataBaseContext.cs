using Microsoft.EntityFrameworkCore;

namespace JWTToken.Models
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<UserInfo> userInfo { get; set; }

        public DbSet<Student> student { get; set; }
    }
}
