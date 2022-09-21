using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class EspecialidadeMedico : IEntityBase
    {
        public int id_medico { get; set; }
        public int id_especialidade { get; set; }
        [ForeignKey("id_medico")]
        public ICollection<Medico> Medicos { get; set; }
        [ForeignKey("id_especialidade")]
        public ICollection<Especialidade> especialidades { get; set; }
    }
}
