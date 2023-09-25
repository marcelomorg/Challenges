
using Microsoft.EntityFrameworkCore;
using Trilha.Model.Models;

namespace Trilha.Persistence.Contexts
{
    public class TrilhaContext : DbContext
    {
        public TrilhaContext(DbContextOptions options): base(options){ }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}