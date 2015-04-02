(function () {

    var app = angular.module("reportModule", []);

    var ReportController = function ($scope, $http) {

        $scope.message = "Client Report";

        $scope.getClients = function () {
            $http.get("../api/ClientAPI")
            .success(function (response) {
                $scope.clients = response;
                alert(response);
            });
        }
    };

    app.controller("ReportController", ["$scope", "$http", ReportController]);

}());