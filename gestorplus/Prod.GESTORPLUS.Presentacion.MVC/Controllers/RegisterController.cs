using System;
using Microsoft.AspNetCore.Mvc;
using Prod.GESTORPLUS.Entidades;
using Prod.GESTORPLUS.Presentacion.Configuracion.Proxys;
using Release.Helper.WebKoMvc.Controllers;
using Release.Helper.WebKoMvc.Filters;
using System.Linq;
using Release.Helper.ReportingServices;

namespace Prod.GESTORPLUS.Presentacion.MVC.Controllers
{
    public partial class RegisterController : CustomBaseController
    {
        private readonly RegisterComandoProxy _registerComando;
        
        public RegisterController(RegisterComandoProxy registerComando)
        {
            _registerComando = registerComando;
        }

        #region VISTA
        [HttpGet]
        //[Route("")]
        [Route("Register")]
        [Route("Register/Index")]
        public IActionResult Index()
        {            
            return View();
        }

        #endregion
                
        #region INSERT/UPDATE/DELETE
        [HttpPost]
        [Route("Register/Registrar")]
        public JsonResult Registrar(Register request)
        {
           var results = _registerComando.Registrar(request);
            return new JsonResult(results);
        }
        
        #endregion                
    }
}
