/**
 * Created by Phil on 1/21/2016.
 */

var pdsSampleApp = angular.module("pdsSampleApp", [
    'ngRoute',
    'controllersModule'
]);

var controllersModule = angular.module('controllersModule', []);

controllersModule.controller('myController', ['$scope', function($scope){
    $scope.pdsModel = {
        myTitle: "snot4"
    }}]);

pdsSampleApp.config([ '$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/viewOne', { templateUrl: 'views/viewOneHtml.html' } )
            .when('/viewTwo', { templateUrl: 'views/viewTwoHtml.html' } );
    }
]);