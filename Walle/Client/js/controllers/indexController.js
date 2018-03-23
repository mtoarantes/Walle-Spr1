WebApp.controller('IndexController', ['$rootScope', '$scope', '$state', '$location', function ($rootScope, $scope, $state, $location) {
    var sessao = null;

    $scope.init = function () {
        $rootScope.isLogged = true;
        $rootScope.sessao = "lala";
        //$scope.ValidaSessao(sessao);
    };

    $scope.ValidaSessao = function () {
        if (sessao == null) {
            $location.path('/login');
            $rootScope.isLogged = false;
        }
        else {
            console.log("error");
        };

        $scope.Sair = function () {
            $rootScope.sessao = null;
            $rootScope.isLogged = false;
            $location.path('/login')
        }
    };
}])