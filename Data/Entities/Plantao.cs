﻿using System.ComponentModel.DataAnnotations.Schema;
using static Infra.Helpers.EnumerablesTips;

namespace Data.Entities
{
    [Table("plantao")]
    public class Plantao : IEntityBase
    {
        public int id_unidade { get; set; }
        public int id_medico { get; set; }
        public int id_especialidade { get; set; }
        public DateTime horarioinicio { get; set; }
        public DateTime horariofim { get; set; }
        public DiasSemana dia_semana { get; set; }

        public ICollection<UnidadeSaude> UnidadeSaudes { get; set; }

        public ICollection<Especialidade> Especialidades { get; set; }
    }
}
