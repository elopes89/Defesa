using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DefesaExercicio.Model.Configuration;

public class PartoConfig : IEntityTypeConfiguration<Parto>
{
    public void Configure(EntityTypeBuilder<Parto> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasOne(x => x.PartoMedico)
            .WithMany(x => x.Partos)
            .HasForeignKey(x => x.Id_Medico)
            .HasConstraintName("FK_Parto_Medico");

        builder.ToTable("Parto");
    }
}
