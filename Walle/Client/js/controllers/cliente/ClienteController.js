WebApp.controller('ClienteController',
    [
        '$rootScope',
        '$scope',
        '$state',
        '$location',
        'NgTableParams',
        'cadastroClienteService',
        '$http',


function ($rootScope, $scope, $state, $location, NgTableParams, cadastroClienteService, $http) {
    $scope.init = function () {
        $scope.BuscaClientes();
    };


    $scope.cliente = {};

    $scope.cadastrar = function (cliente) {
        cadastroClienteService.putCliente(cliente, function (data) {
            $scope.resetForm(cliente);
        }
        );
    };

    $scope.tabs = [
      { title: 'Cadastro', icon: "glyphicon glyphicon-edit", tabContent: 'views/cliente/cadastro-de-clientes.html' },
      { title: 'Clientes', icon: "glyphicon glyphicon-list-alt", tabContent: 'views/cliente/views-cliente.html' }
    ];

    $scope.buscaCepViaCep = function (cep) {
        var url = "https://viacep.com.br/ws/" + cep + "/json/";
        $http.get(url).then(function (res) {
            $scope.cliente.Des_Endereco = res.data.logradouro;
            $scope.cliente.Des_Bairro = res.data.bairro;
            $scope.cliente.Des_Cidade = res.data.localidade;
            $scope.cliente.Des_Estado = res.data.uf;
        });
    }

    $scope.resetForm = function (form) {
        angular.copy({}, form);
    };

    $scope.lostFocus = function () {
        if ($scope.cliente.Des_Cep != undefined && $scope.cliente.Des_Cep.length > 0) {
            $scope.buscaCepViaCep($scope.cliente.Des_Cep);
        }
    }

    //===========================================================================
    $scope.ngParametros = new NgTableParams();
    $scope.listClientes = [];
    $scope.BuscaClientes = function () {
        cadastroClienteService.getCliente(function (response) {
            $scope.listClientes = response;
            $scope.ngParametros = $scope.getNgTableParametros($scope.listClientes);
        })
    }

    
    $scope.getNgTableParametros = function (data) {
        var initialParams = {
            count: 6 // Registro por página
        };
        var initialSettings = {
            // page size buttons (right set of buttons in demo)
            counts: [],
            // determines the pager buttons (left set of buttons in demo)
            paginationMaxBlocks: 13,
            paginationMinBlocks: 2,
            dataset: data
        };
        return new NgTableParams(initialParams, initialSettings);
    }
}])