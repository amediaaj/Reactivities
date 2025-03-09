using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<Activity> Activities { get; set; }
}
