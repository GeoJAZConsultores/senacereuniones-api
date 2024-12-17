using AutoMapper;
using Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Models.Acreditaciones;
using Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Datos.Paginado;
using Jazani.Senace.Reuniones.Dominio.Acreditaciones.Repository;
using Microsoft.Extensions.Logging;


namespace Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Services.Implementaciones
{
    public class AcreditacionServices : IAcreditacionServices
    {
        private readonly IAcreditacionRepository _acreditacionRepositorio;
        private readonly IMapper _mapper;
        private readonly ILogger<AcreditacionServices> _logger;
        
        public AcreditacionServices(IAcreditacionRepository acreditacionRepositorio, IMapper mapper, ILogger<AcreditacionServices> logger)
        {
            _acreditacionRepositorio = acreditacionRepositorio;
            _mapper = mapper;
            _logger = logger;
        }

        public Task<AcreditacionDto> CreateAsync(AcreditacionSaveDto saveDto)
        {
            throw new NotImplementedException();
        }

        public Task<AcreditacionDto> DisabledAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AcreditacionDto> EditAsync(int id, AcreditacionSaveDto saveDto)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<AcreditacionDto>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<AcreditacionDto>> FindAllPaginatedAsync(PageRequest<AcreditacionFilterDto> request)
        {
            throw new NotImplementedException();
        }

        public Task<AcreditacionDto> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<AcreditacionDto>> FindGeneralAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AcreditacionDto> UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
