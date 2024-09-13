using FrontToBackTask1.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackTask1.DataAccessLayer.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<TeacherGroup> TeacherGroups { get; set; }
}
