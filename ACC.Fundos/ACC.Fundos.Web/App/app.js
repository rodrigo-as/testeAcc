var app = angular.module('app', ['ui.router']);

app.config(function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/fundos');

    $stateProvider
        .state('fundos', {
            url: "/fundos",
            templateUrl: '/App/components/fundos/fundos.html',
            controller: 'fundosController'
        });

});