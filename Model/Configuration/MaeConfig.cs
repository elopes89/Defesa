using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DefesaExercicio.Model.Configuration;

public class MaeConfig : IEntityTypeConfiguration<Mae>
{
    public void Configure(EntityTypeBuilder<Mae> builder)
    {
        builder.HasKey(x => x.Id);
        builder.ToTable("Mae");
    }
}