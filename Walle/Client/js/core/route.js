WebApp.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
    $locationProvider.hashPrefix('');
    $urlRouterProvider.otherwise('');


    //var uiTabs = {
    //    name: 'tabs',
    //    url: '/cadastro/cadastro-de-clientes',
    //    templateUrl: 'tabs'
    //}


    var clientes = {
        name: 'cadastro-clientes',
        url: '/cadastro/cadastro-de-clientes',
        templateUrl: '/views/cliente/clientes.html'
    }


    var login = {
        name: 'login',
        url: '/login',
        templateUrl: 'login.html'
    }

    var footer = {
        name: 'footer',
        url: '/footer',
        templateUrl: 'footer.html'
    }

    $stateProvider.state(login);
    $stateProvider.state(footer);
    $stateProvider.state(clientes);
});

