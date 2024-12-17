using Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Models.Acreditaciones;
using Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Services;
using Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Datos.Paginado;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Jazani.Senace.Reuniones.Api.Controllers.Acreditaciones
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcreditacionController : ControllerBase
    {
        private readonly IAcreditacionServices _acreditacionServicio;
        public AcreditacionController(IAcreditacionServices acreditacionServicio)
        {
            _acreditacionServicio = acreditacionServicio;
        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IReadOnlyList<AcreditacionDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(NotFoundResult))]
        public async Task<Results<NotFound, Ok<IReadOnlyList<AcreditacionDto>>>> GetAll()
        {
            var response = await _acreditacionServicio.FindAllAsync();
            return TypedResults.Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AcreditacionDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(NotFoundResult))]
        public async Task<Results<NotFound, Ok<AcreditacionDto>>> GetById(int id)
        {
            var response = await _acreditacionServicio.FindByIdAsync(id);
            return TypedResults.Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AcreditacionDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(NotFoundResult))]
        public async Task<Results<NotFound, CreatedAtRoute<AcreditacionDto>>> Create([FromBody] AcreditacionSaveDto acreditacionSaveDto)
        {
            var response = await _acreditacionServicio.CreateAsync(acreditacionSaveDto);
            return TypedResults.CreatedAtRoute(response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AcreditacionDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(NotFoundResult))]
        public async Task<Results<NotFound, Ok<AcreditacionDto>>> Update(int id, [FromBody] AcreditacionSaveDto acreditacionSaveDto)
        {
            var response = await _acreditacionServicio.EditAsync(id, acreditacionSaveDto);
            return TypedResults.Ok(response);
        }


        [HttpGet("BusquedaPaginada")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PageResponse<AcreditacionDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(NotFoundResult))]
        public async Task<Results<NotFound, Ok<PageResponse<AcreditacionDto>>>> PaginatedSearch([FromQuery] PageRequest<AcreditacionFilterDto> request)
        {
            var response = await _acreditacionServicio.FindAllPaginatedAsync(request);
            return TypedResults.Ok(response);
        }
    }
}
