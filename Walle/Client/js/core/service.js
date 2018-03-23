WebApp.factory("LoginService", ['$http', function ($http) {
    var url = config.server + 'api/ClienteUsuarioAdmin';

    http_success = function (response, callback) {
        msg = 'Autenticado com sucesso.';
        alertify.set('notifier', 'position', 'top-right');
        alertify.success(msg);
        callback(response.data, response.status, response.headers, response.config);
    }

    http_fail = function (response, callback) {
        if (callback) {
            callback(response.data, response.status, response.headers, response.config);
        }
        var msg;
        switch (response.status) {
            case 409:
                msg = 'Registro já inserido/Conflito na chave';
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 0:
                msg = "Erro ao comunicar com o servidor!";
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 900:
                msg = getResponseMessage(response);
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 901:
                msg = getResponseMessage(response);
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 902:
                msg = getResponseMessage(response);
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            default:
                msg = 'Ocorreu um erro na requisição';
                msg += response.data && response.data.ExceptionMessage ? ': ' + response.data.ExceptionMessage : '!';
                msg += response.data && response.data.Message ? ': ' + response.data.Message : '!';
                alertify.error(msg);

        }

    }, getResponseMessage = function (response) {

        if (response.data != undefined) {
            return response.data.Message;
        } else if (response.responseText != undefined) {
            var j = angular.fromJson(response.responseText);
            return j.Message;
        } else {
            return 'Ocorreu um erro na requisição';
        }

    };

    return {
        getUsuarioAdmin: function (obj, callBackSucess, callBackError) {
            return $http.post(url + config.localPath + 'Autenticacao', obj, {})
                .then(function (response) {
                    http_success(response, callBackSucess);
                }, function (response) {
                    http_fail(response, callBackError);
                });
        }        
    };

}])

WebApp.factory("cadastroClienteService", ['$http', function ($http) {
    var url = config.server + 'api/Cliente';

    http_success = function (response, callback) {
        if (response.config.method != 'GET') {
            msg = 'Cliente registrado com sucesso.';
            alertify.set('notifier', 'position', 'top-right');
            alertify.success(msg);
            callback(response.data, response.status, response.headers, response.config);
        }
        else {
            callback(response.data, response.status, response.headers, response.config);
        }
    }

    http_fail = function (response, callback) {
        if (callback) {
            callback(response.data, response.status, response.headers, response.config);
        }
        var msg;
        switch (response.status) {
            case 409:
                msg = 'Registro já inserido/Conflito na chave';
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 0:
                msg = "Erro ao comunicar com o servidor!";
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 900:
                msg = getResponseMessage(response);
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 901:
                msg = getResponseMessage(response);
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            case 902:
                msg = getResponseMessage(response);
                alertify.set('notifier', 'position', 'top-right');
                alertify.error(msg);
                break;
            default:
                msg = 'Ocorreu um erro na requisição';
                msg += response.data && response.data.ExceptionMessage ? ': ' + response.data.ExceptionMessage : '!';
                msg += response.data && response.data.Message ? ': ' + response.data.Message : '!';
                alertify.error(msg);

        }

    }, getResponseMessage = function (response) {

        if (response.data != undefined) {
            return response.data.Message;
        } else if (response.responseText != undefined) {
            var j = angular.fromJson(response.responseText);
            return j.Message;
        } else {
            return 'Ocorreu um erro na requisição';
        }

    };

    return {
        putCliente: function (obj, callBackSucess, callBackError) {
            return $http.put(url, obj, {})
                .then(function (response) {
                    http_success(response, callBackSucess);
                }, function (response) {
                    http_fail(response, callBackError);
                });
        },

        getCliente: function (callBackSucess, callBackError) {
            return $http.get(url)
                .then(function (response) {
                    http_success(response, callBackSucess);
                }, function (response) {
                    http_fail(response, callBackError);
                });
        },

    };

}])
