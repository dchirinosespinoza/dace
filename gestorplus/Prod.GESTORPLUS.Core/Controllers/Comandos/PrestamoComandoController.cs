using Microsoft.AspNetCore.Mvc;
using Prod.GESTORPLUS.Entidades;
using Prod.GESTORPLUS.Servicios.Applicacion.Interfaces;
using Release.Helper;
using Release.Helper.Pagination;

namespace Prod.GESTORPLUS.Servicios.Controllers
{
    [Route("[controller]")]
    public class PrestamoComandoController : Controller
    {
        private readonly IPrestamoAplicacion _personaAplicacion;

        public PrestamoComandoController(IPrestamoAplicacion personaAplicacion)
        {
            _personaAplicacion = personaAplicacion;

        }


        [HttpPost]
        [Route("Registrar")]
        public StatusResponse Registrar([FromBody]PrestamoRequest request)
        {
            return _personaAplicacion.Registrar(request);
        }
        [HttpPost]
        [Route("Actualizar")]
        public StatusResponse Actualizar([FromBody]PrestamoRequest request)
        {
            return _personaAplicacion.Actualizar(request);
        }
        
    }
}
