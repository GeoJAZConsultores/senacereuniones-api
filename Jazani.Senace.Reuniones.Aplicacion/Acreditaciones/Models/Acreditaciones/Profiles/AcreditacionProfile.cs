using AutoMapper;
using Jazani.Senace.Reuniones.Dominio.Acreditaciones.Models;


namespace Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Models.Acreditaciones.Profiles
{
    public class AcreditacionProfile : Profile 
    {
        public AcreditacionProfile() 
        {
            CreateMap<Acreditacion, AcreditacionDto>().ReverseMap();
            CreateMap<Acreditacion, AcreditacionSaveDto>().ReverseMap();
        }
    }
}
