using System.ComponentModel.DataAnnotations.Schema;

namespace DefesaExercicio.Model;


public class Bebe{

    public int Id { get; set; }
    public DateTime Data_Nascimento { get; set; }
    [Column("Peso_Nascimento", TypeName ="decimal(1,3)")]
    public decimal Peso_Nascimento { get; set; }
    public int Altura { get; set; }
    public int Id_Mae {get; set;}
    public int Id_Parto {get; set;}

    public virtual Mae? BebeMae { get; set; }

    public virtual Parto? BebeParto { get; set; }

}