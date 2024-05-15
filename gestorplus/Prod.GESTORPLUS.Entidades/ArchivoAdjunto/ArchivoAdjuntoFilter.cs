using Release.Helper.Pagination;

namespace Prod.GESTORPLUS.Entidades
{
    public class ArchivoAdjuntoFilter : PagedRequest
    {
        public string tipoHoja { get; set; }
        public string idExpSitradoc { get; set; } 
        public long codigotrabajador { get; set; }
        public int coddep { get; set; }
    }
}
