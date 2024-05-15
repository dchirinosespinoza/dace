﻿using Microsoft.AspNetCore.Mvc;
using Prod.GESTORPLUS.Entidades;
using Prod.GESTORPLUS.Presentacion.Configuracion.Proxys;
using Release.Helper.WebKoMvc.Controllers;
using System.Linq;

namespace Prod.GESTORPLUS.Presentacion.MVC.Controllers
{
    public partial class HomeController : CustomBaseController
    {
        private readonly ComunConsultaProxy _comun;

        public HomeController(ComunConsultaProxy comun)
        {
            _comun = comun;
        }

        [HttpGet]
        /*[Route("")]
        [Route("/")]
        [Route("Home")]
        [Route("Home/Index")]*/
        public IActionResult Index()
        {
            return View();
        }

    }

}
