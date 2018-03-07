WebApp.controller('IndexController', ['$scope', '$state', function ($scope, $state) {
    var sessao = null;

    $scope.init = function () {
        $scope.ValidaSessao(sessao);
    };

    $scope.ValidaSessao = function () {
        if (sessao == null) {
            $state.go('login');
        }
        else {
            console.log("error");
        };
    };
}])