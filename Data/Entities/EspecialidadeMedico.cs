using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("especialidade_medico")]

    public class EspecialidadeMedico : IEntityBase
    {
        public int id_medico { get; set; }
        public int id_especialidade { get; set; }
        //[ForeignKey("id_medico")]
        //public ICollection<Medico> Medicos { get; set; }

        [ForeignKey("id_especialidade")]
        public ICollection<Especialidade> especialidades { get; set; }
    }
}
