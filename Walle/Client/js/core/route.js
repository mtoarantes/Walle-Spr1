WebApp.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {

    $urlRouterProvider.otherwise('/');
    
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
    
});

