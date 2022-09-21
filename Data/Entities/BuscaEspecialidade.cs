using Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class BuscaEspecialidade : IEntityBase
    {
        public int id_especialidade { get; set; }
        public string descricao { get; set; }

        [ForeignKey("id_especialidade")]
        public Especialidade Especialidade { get; set; }
    }
}
