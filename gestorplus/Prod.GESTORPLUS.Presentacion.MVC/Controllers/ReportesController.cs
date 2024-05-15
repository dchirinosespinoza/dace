using System;
using Microsoft.AspNetCore.Mvc;
using Prod.GESTORPLUS.Entidades;
using Prod.GESTORPLUS.Presentacion.Configuracion.Proxys;
using Release.Helper.WebKoMvc.Controllers;
using Release.Helper.WebKoMvc.Filters;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Prod.GESTORPLUS.Enumerados;
using Release.Helper.ReportingServices;

namespace Prod.GESTORPLUS.Presentacion.MVC.Controllers
{
    public partial class ReportesController : CustomBaseController
    {
        
        private readonly IReportManager _reportManager;
        public ReportesController(IReportManager reportManager)
        {
        
            _reportManager = reportManager;


        }

        #region VISTA
        [HttpGet]
        //[Route("")]
        [Route("Reportes")]
        [Route("Reportes/Index")]
        public IActionResult Index()
        {
            return View();
        }


        #endregion

        #region GET
        
        [HttpPost]
        [Route("Reportes/Personas")]
        public IActionResult GetReporte(ReporteFilter filter)
        {
            try
            {
                ReportFormat format = (filter.Formato == "PDF" ? ReportFormat.PDF : (filter.Formato == "XLSX" ? ReportFormat.EXCEL : ReportFormat.PDF));
                var report = _reportManager.GetReportFromServer(filter.Rdl, format, filter.Parametros);

                filter.Formato = filter.Formato == "XLSX" ? "XLS" : filter.Formato;

                return File(report.FileBytes, report.ContentType, $"{filter.NombreReporte}-{DateTime.Now:dd-MM-yyyy}.{filter.Formato.ToLower()}");
            }
            catch (Exception e)
            {
                return Json("Ocurrió un error al descargar");
            }
            
        }
        #endregion


    }
}
