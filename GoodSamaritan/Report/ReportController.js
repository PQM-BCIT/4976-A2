(function () {

    var app = angular.module("reportModule", []);

    var ReportController = function ($scope, $http) {

        $scope.message = "Client Report";
        
        var _year = {
            FiscalYearId: 0,
            FiscalYear: "Loading..."
        };
        $scope.years = [_year];

        // Grabs the fiscal years from the database
        $http.get("../api/FiscalYearAPI") // will be changes to http://a3.thedistantvoice.me/api/FiscalYearAPI in the future..?
        .success(function (response) {
            $scope.years = response;
        });

        $scope.getClients = function () {
            $http.get("../api/ClientAPI") // will be changes to http://a3.thedistantvoice.me/api/ClientAPI in the future..?
            .success(function (response) {
                $scope.clients = response;
            });
        }
    };

    app.controller("ReportController", ["$scope", "$http", ReportController]);

}());