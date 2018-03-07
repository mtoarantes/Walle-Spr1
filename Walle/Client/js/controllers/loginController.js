WebApp.controller("LoginController", ["$scope", "$rootScope", "$state", "LoginService", function ($scope, $rootScope, $state, LoginService) {

    $scope.retornoBanco = {
        usuario: 'marco.tulio',
        senha: 'walle2018'
    };

    $scope.acesso = {};

    $scope.Acessar = function (acesso) {
        if (acesso.usuario == retornoBanco.usuario && acesso.senha == retornoBanco.senha) {
            MsgSucesso("Usuário Autorizado!");
            $state.go('/');
        }
        else {
            MsgFalha("Usuário negado!");
        }
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