WebApp.controller("LoginController", ["$scope", "$rootScope", "$location", "LoginService", function ($scope, $rootScope, $location, LoginService) {

    $scope.acesso = {};
    $scope.Acessar = function (acesso) {
        LoginService.getUsuarioAdmin(acesso, function (data) {
            sessionStorage.isLogged = true;
            sessionStorage.Username = data.Des_Nome_Completo;
            $rootScope.sessao = sessionStorage.Username;
            $rootScope.isLogged = sessionStorage.isLogged;
            $location.path('/');
        }
        );
    }

    function MsgSucesso(msg) {
        alertify.set('notifier', 'position', 'top-right');
        alertify.success(msg);
    };

    function MsgFalha(msg) {
        alertify.set('notifier', 'position', 'top-right');
        alertify.error(msg);
    };
}])