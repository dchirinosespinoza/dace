using Prod.GESTORPLUS.Entidades;
using Release.Helper;
using Release.Helper.Pagination;

namespace Prod.GESTORPLUS.Servicios.Applicacion.Interfaces
{
    public interface IRegisterAplicacion
    {
        StatusResponse Registrar(Register register);
        
    }
}
