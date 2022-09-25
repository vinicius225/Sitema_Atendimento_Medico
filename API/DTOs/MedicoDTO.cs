using static Infra.Helpers.EnumerablesTips;

namespace API.DTOs
{
    public class MedicoDTO 
    {
        public string nome { get; set; }
        public string crm { get; set; }
        public string estado_crm { get; set; }
        public DateTime criado { get; set; } = DateTime.Now;
        public DateTime editado { get; set; } = DateTime.Now;
        public situationDefault situacao { get; set; }
    }
}
