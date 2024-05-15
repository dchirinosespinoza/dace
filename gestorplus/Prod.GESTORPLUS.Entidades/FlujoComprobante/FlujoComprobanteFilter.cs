using Release.Helper.Pagination;

namespace Prod.GESTORPLUS.Entidades
{
    public class FlujoComprobanteFilter : PagedRequest
    {
        public int? idComprobantePago { get; set; }        
    }
}
