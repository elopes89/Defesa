namespace DefesaExercicio.Model;

public class Parto
{
    public int Id { get; set; }
    public DateTime Data_Parto { get; set; }
    public DateTime Horario_Parto { get; set; }
    public int Id_Medico { get; set; }

    public virtual ICollection<Bebe> Bebes { get; set; }
    public virtual Medico? PartoMedico { get; set; }
}
