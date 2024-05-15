using Microsoft.AspNetCore.Mvc;
using Prod.GESTORPLUS.Entidades;
using Prod.GESTORPLUS.Servicios.Applicacion.Interfaces;
using Release.Helper;
using Release.Helper.Pagination;

namespace Prod.GESTORPLUS.Servicios.Controllers
{
    [Route("[controller]")]
    public class RegisterComandoController : Controller
    {
        private readonly IRegisterAplicacion _registerAplicacion;

        public RegisterComandoController(IRegisterAplicacion registerAplicacion)
        {
            _registerAplicacion = registerAplicacion;

        }


        [HttpPost]
        [Route("Registrar")]
        public StatusResponse Registrar([FromBody]Register register)
        {
            return _registerAplicacion.Registrar(register);
        }
        
        
    }
}
