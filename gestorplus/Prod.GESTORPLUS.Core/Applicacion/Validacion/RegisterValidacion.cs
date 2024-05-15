
using Prod.GESTORPLUS.Datos;
using Prod.GESTORPLUS.Entidades;
using Release.Helper;
using Release.Helper.Data.ICore;
using System.Collections.Generic;
using Modelo = Prod.GESTORPLUS.Datos.Modelo;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;

namespace Prod.GESTORPLUS.Servicios.Applicacion
{
    public class RegisterValidacion : ValidacionGenerica
    {
        private IContext _context;
        private IUnitOfWork _uow;
        public readonly IConfiguration _configuration;
        public RegisterValidacion(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _uow = unitOfWork;
            _context = _uow.Context;
            _configuration = configuration;
        }

        public List<string> ValidarRegistro(Register register)
        {            
            return Msg;
        }
        
    }
}
