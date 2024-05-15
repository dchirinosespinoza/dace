define(["jquery", 'knockout', "ns", 'ajaxService', 'alertService', "domReady"], function ($, ko, ns, ajaxService, alertService, domReady) {
    $(document).ready(function () {
        $("#txtDetalleFiltro").Alfanumerico();

    });
    function viewModel(params) {

        var self = this;

        //VARIABLES
        self.ns = ns;
        self.modelParent = params.modelParent;

        //FUNCIONES
        self.Reset = function () {
            ko.mapping.fromJS({
                Nombre: null,
                ApePaterno: null,
                ApeMaterno: null,
                Email: null
                //PageSize: self.Grid.pageSize()
            }, self.modelParent.Datos);
        };

        self.Guardar = function () {

            var valid = self.ValidarRegistro();

            if (valid) {

                var usuario = ko.mapping.toJS(self.modelParent.Datos);
                usuario.Opc = '1';

                var url = "/Register/Registrar";
                
                ko.Confirm({ message: "<b>Está seguro de guardar los datos.?</b>" },
                    function () {
                        ajaxService.Post(ns.URL + url, usuario
                            , function (response) {
                                if (response.Success) {
                                    alertService.displaySuccessNotification("Se han guardado los datos satisfactoriamente.");
                                    //redsirect a página principal
                                } else {
                                    alertService.displayWarningNotification(response.Messages);
                                }
                            },
                            function (d) {
                                alertService.displayErrorNotification(d);

                            });
                    });

            }
        }

        self.ValidarRegistro = function () {
            var message = [];

            return true;
        }

        self.Init = function () {

            self.Reset();
        }

        //INICIO
        self.Init();
    }
    return {
        viewModel: viewModel,
        /*
        ,template: ``
        */
    };
});
