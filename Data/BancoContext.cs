using Microsoft.EntityFrameworkCore;
using TuDu.Models;

namespace TuDu.Data;

public class BancoContext:DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options):base(options)
    {

    }

    public DbSet<TaskModel> Tasks { get; set; }
}
