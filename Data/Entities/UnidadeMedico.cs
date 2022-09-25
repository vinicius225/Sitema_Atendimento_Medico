using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("unidade_saude_medico")]

    public class UnidadeMedico : IEntityBase
    {
        public int id_unidade { get; set; }
        public int id_medico  { get; set; }



        [ForeignKey("id_unidade")]
        public ICollection<UnidadeSaude> UnidadeSaudes { get; set; }


        //[ForeignKey("id_medico")]
        //public ICollection<Medico> Medicos { get; set; }
    }
}
