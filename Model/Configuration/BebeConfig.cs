using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DefesaExercicio.Model.Configuration;

public class BebeConfig : IEntityTypeConfiguration<Bebe>
{
    public void Configure(EntityTypeBuilder<Bebe> builder)
    {

        builder
            .HasOne(x => x.BebeMae)
            .WithMany(x => x.Bebes)
            .HasForeignKey(x => x.Id_Mae)
            .HasConstraintName("FK_Bebe_Mae");

        builder
            .HasOne(x => x.BebeParto)
            .WithMany(x => x.Bebes)
            .HasForeignKey(x => x.Id_Parto)
            .HasConstraintName("FK_Bebe_Parto");


        builder.HasKey(x => x.Id);
       

        builder.ToTable("Bebe");
    }
}
