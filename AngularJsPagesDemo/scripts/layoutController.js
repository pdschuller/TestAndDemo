/**
 * Created by Phil on 1/21/2016.
 */

var pdsSampleApp = angular.module("pdsSampleApp", [
    // 'ngRoute',
    'controllersModule'
]);

var controllersModule = angular.module('controllersModule', []);

controllersModule.controller('myController', ['$scope', function($scope){
    $scope.pdsModel = {
        myTitle: "snot4"
    }}]);
