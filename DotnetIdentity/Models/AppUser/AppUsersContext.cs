using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DotnetIdentity.Models.Note;

namespace DotnetIdentity.Models.AppUser;

public partial class AppUsersContext : IdentityDbContext<User>
{
    public AppUsersContext(DbContextOptions<AppUsersContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<IdentityUser>()
        //   .ToTable("AspNetUsers");
        //modelBuilder.Entity<User>()
        //   .ToTable("AspNetUsers");
    }

}
