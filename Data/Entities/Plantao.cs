using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Entities
{
    public class Plantao : IEntityBase
    {
        public int id_unidade { get; set; }
        public int id_medico { get; set; }
        public int id_especialidade { get; set; }
        public DateTime horarioinicio { get; set; }
        public DateTime horariofim { get; set; }
        public DiasSemana dia_semana { get; set; }

        [ForeignKey("id_unidade")]
        public ICollection<UnidadeSaude> UnidadeSaudes { get; set; }

        [ForeignKey("id_medico")]
        public ICollection<Medico> Medicos { get; set; }

        [ForeignKey("id_especialidade")]
        public ICollection<Especialidade> Especialidades { get; set; }
    }
}
