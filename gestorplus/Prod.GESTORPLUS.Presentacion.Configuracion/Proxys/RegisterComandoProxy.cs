using Prod.GESTORPLUS.Entidades;
using Release.Helper;
using Release.Helper.Proxy;
using System.Net.Http;

namespace Prod.GESTORPLUS.Presentacion.Configuracion.Proxys
{
    public class RegisterComandoProxy : BaseProxy
    {
        private readonly string _url;

        public RegisterComandoProxy(AppConfig appConfig)
        {
            _url = string.Format("{0}RegisterComando/", appConfig.Urls.URL_BUPER_Core_API);

        }
             
        public StatusResponse Registrar(Register register)
        {
            return this.InvokeWebApi<StatusResponse>(HttpMethod.Post, _url + "Registrar", this.GetJsonParameters(register));
        }
    }

}
