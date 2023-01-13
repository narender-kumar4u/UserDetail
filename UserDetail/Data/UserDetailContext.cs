using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserDetail.Models;

namespace UserDetail.Data
{
    public class UserDetailContext : DbContext
    {
        public UserDetailContext (DbContextOptions<UserDetailContext> options)
            : base(options)
        {
        }

        public DbSet<UserDetail.Models.User> User { get; set; } = default!;
    }
}
