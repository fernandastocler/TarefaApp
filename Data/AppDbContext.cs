using Microsoft.EntityFrameworkCore;
using TarefasApi.Models;

namespace TarefasApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Tarefa> Tarefas => Set<Tarefa>();
}
