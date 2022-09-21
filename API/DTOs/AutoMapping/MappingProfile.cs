using AutoMapper;

namespace API.DTOs.AutoMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
                CreateMap<MedicoDTO,MedicoDTO>().ReverseMap();
        }
    }
}
