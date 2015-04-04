(function () {

    var app = angular.module("reportModule", []);

    var ReportController = function ($scope, $http) {

        $scope.message = "Client Report";

        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!
        var yyyy = today.getFullYear();
        if (dd < 10) {
            dd = '0' + dd
        }
        if (mm < 10) {
            mm = '0' + mm
        }

        $scope.currentDate = mm + '/' + dd + '/' + yyyy;

        var _year = {
            FiscalYearId: 0,
            FiscalYear: "Loading..."
        };
        $scope.years = [_year];

        // Grabs the fiscal years from the database
        $http.get("../api/FiscalYearAPI") // will be changed to http://a3.thedistantvoice.me/api/FiscalYearAPI in the future..?
        .success(function (response) {
            $scope.years = response;
        });

        $scope.getClients = function () {
            $http.get("../api/ClientAPI") // will be changed to http://a3.thedistantvoice.me/api/ClientAPI in the future..?
            .success(function (response) {
                $scope.clients = response;
            });
        }
    };

    app.controller("ReportController", ["$scope", "$http", ReportController]);

}());