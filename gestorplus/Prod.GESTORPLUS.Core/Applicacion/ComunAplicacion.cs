using Prod.GESTORPLUS.Datos;
using Prod.GESTORPLUS.Datos.Modelo;
using Prod.GESTORPLUS.Servicios.Applicacion.Interfaces;
using Release.Helper;
using Release.Helper.Data.ICore;
using Release.Helper.Pagination;
using System.Collections.Generic;
using System.Linq;
using Modelo = Prod.GESTORPLUS.Datos.Modelo;

namespace Prod.GESTORPLUS.Servicios.Applicacion
{
    public class ComunAplicacion : IComunAplicacion
    {
        private IContext _context;
        private IUnitOfWork _uow;
        public ComunAplicacion(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
            _context = _uow.Context;
        }


        public IEnumerable<Item> GetConceptosList()
        {
            var list = _context.Query<Modelo.persona>()
                                .OrderBy(c => c.nombre)
                                .Select(t => new Item
                                {
                                    Value = t.id_persona,
                                    Text = t.nombre
                                });
            return list;
        }



    }
}
