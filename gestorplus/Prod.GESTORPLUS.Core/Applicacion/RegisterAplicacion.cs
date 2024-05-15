using Prod.GESTORPLUS.Datos;
using Prod.GESTORPLUS.Entidades;
using Prod.GESTORPLUS.Servicios.Applicacion.Interfaces;
using Release.Helper;
using Release.Helper.Data.ICore;
using Release.Helper.Pagination;
using System.Collections.Generic;
using System.Linq;
using Prod.GESTORPLUS.Core.Applicacion;

namespace Prod.GESTORPLUS.Servicios.Applicacion
{
    public class RegisterAplicacion : IRegisterAplicacion
    {
        private IContext _context;
        private IUnitOfWork _uow;
        private readonly RegisterValidacion _registerValidacion;
        public RegisterAplicacion(
            IUnitOfWork unitOfWork,
            RegisterValidacion registerValidacion)
        {
            _uow = unitOfWork;
            _context = _uow.Context;
            _registerValidacion = registerValidacion;
        }


        #region GET
                                
        #endregion

        #region INSERT/UPDATE/DELETE
        public StatusResponse Registrar(Register register)
        {
            var sr = new StatusResponse();

            var errores = _registerValidacion.ValidarRegistro(register);
            if (errores.Any())
            {
                sr.Messages = errores;
                return sr;
            }

            try
            {
                _uow.BeginTransaction();
                                
                var registro = _uow.p_REGISTER_Registrar(register);

                if (registro)
                {
                    _uow.Commit();
                    sr.Success = true;
                    sr.Messages.Add("Se ha registrado satisfactoriamente");
                }
                else
                {
                    _uow.Rollback();
                    sr.Success = false;
                    sr.Messages.Add("No se pudo registrar los datos");
                }

            }
            catch (System.Exception ex)
            {
                _uow.Rollback();
                sr.Success = false;
                sr.Messages.Add(string.Format("Error inesperado:{0}", ex.Message));
            }
            return sr;
        }

        #endregion



    }
}
