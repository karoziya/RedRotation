using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedRotation.Model;

namespace RedRotation.Data
{
  public class RedRotationContext : DbContext
  {
    public RedRotationContext(DbContextOptions<RedRotationContext> options)
        : base(options)
    {
      Database.EnsureCreated();
    }

    public DbSet<RedRotation.Model.Teammate> Teammate { get; set; } = default!;
    public DbSet<RedRotation.Model.Activity> Activity { get; set; } = default!;
  }
}
