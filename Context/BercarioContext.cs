using DefesaExercicio.Model.Configuration;
using DefesaExercicio.Model;
using Microsoft.EntityFrameworkCore;

namespace DefesaExercicio.Context;

public class BercarioContext : DbContext
{
    public BercarioContext(DbContextOptions<BercarioContext> options)
        : base(options) { }

    public DbSet<Bebe>? Bebes { get; set; }
    public DbSet<Mae>? Maes { get; set; }
    public DbSet<Medico>? Medicos { get; set; }
    public DbSet<Parto>? Partos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        modelBuilder.ApplyConfiguration(new BebeConfig());
        modelBuilder.ApplyConfiguration(new MedicoConfig());
        modelBuilder.ApplyConfiguration(new PartoConfig());
        modelBuilder.ApplyConfiguration(new MaeConfig());

    }
}
