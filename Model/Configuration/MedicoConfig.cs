using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DefesaExercicio.Model.Configuration;

public class MedicoConfig : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable("Medico");
    }
}
