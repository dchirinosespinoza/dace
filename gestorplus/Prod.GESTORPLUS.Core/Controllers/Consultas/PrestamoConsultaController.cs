﻿using Microsoft.AspNetCore.Mvc;
using Prod.GESTORPLUS.Entidades;
using Prod.GESTORPLUS.Servicios.Applicacion.Interfaces;
using Release.Helper;
using Release.Helper.Pagination;

namespace Prod.GESTORPLUS.Servicios.Controllers
{
    [Route("[controller]")]
    public class PrestamoConsultaController : Controller
    {
        private readonly IPrestamoAplicacion _prestamoAplicacion;

        public PrestamoConsultaController(IPrestamoAplicacion prestamoAplicacion)
        {
            _prestamoAplicacion = prestamoAplicacion;

        }
        [HttpGet]
        [Route("GetPrestamos")]
        public PagedResponse<PrestamoResponse> GetPrestamos([FromBody]PrestamoFilter filtro)
        {
            return _prestamoAplicacion.GetPrestamos(filtro);
        }
              
                
    }
}
