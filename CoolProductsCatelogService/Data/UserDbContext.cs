using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatelogService.Data
{
    public class UserDbContext : IdentityDbContext<IdentityUser>
    {

        // map tables

        // config db
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
    }
}
