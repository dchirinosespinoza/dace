define(["jquery", "knockout", "ns", "ajaxService"], function ($, ko, ns, ajaxService) {
    "use strict";

    var Modelo = function () {

        //VARIABLES
        var self = this;
        
        self.Datos = ko.mapping.fromJS({
            Nombre: null,
            ApePaterno: null,
            ApeMaterno: null,
            Email: null
            //PageSize: self.Grid.pageSize()
        });
        
        //FUNCIONES        
                
        self.Init = function () {
            //self.getDependencias();
        }

        //EVENTOS
        self.Registrar = function () { }//function que se sobrescribe en [app-register-form]
        //self.MostrarRegister = function () { }//function que se sobrescribe en [app-register-form]
        //INICIO
        self.Init();

    }

    ko.applyBindingsCustom(new Modelo(), ns.CONTAINER);
}
);
