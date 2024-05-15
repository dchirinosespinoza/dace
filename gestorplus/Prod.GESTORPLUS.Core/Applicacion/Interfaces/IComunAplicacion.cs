using Prod.GESTORPLUS.Entidades;
using Release.Helper;
using Release.Helper.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prod.GESTORPLUS.Servicios.Applicacion.Interfaces
{
    public interface IComunAplicacion
    {
        IEnumerable<Item> GetConceptosList();
    }
}
