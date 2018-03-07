WebApp.factory("LoginService", ['$http', function ($http) {
    var url = config.server + 'api/ConfiguracaoCentroResultado';
    retornoBanco = {
        usuario: 'marco.tulio',
        senha: 'walle2018'
    };

    return {
        
        indexGet: function (acesso) {
            return {
            }
        },

        indexPost: function (form) {
            return $http.post(url, form);
        }
    }
}])
