﻿(function () {

    var app = angular.module("reportModule", []);

    var ReportController = function ($scope, $http) {

        $scope.showLoading = true;

        $http.get("http://a3.thedistantvoice.me/api/ClientAPI/ReportLogin")
        .success(function (response) {
            $scope.showLoading = false;
            if (response == "true") {
                $scope.report = response;
                $scope.showLogin = false;
                $scope.showReport = true;
                getYear();
            } else {
                $scope.showLogin = true;
                $scope.showReport = false;
            }
        })

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

        getYear = function () {
            // Grabs the fiscal years from the database
            $http.get("http://a3.thedistantvoice.me/api/FiscalYearAPI")
            .success(function (response) {
                $scope.years = response;
            });
        }

        $scope.getReport = function () {

            $scope.showReportLoading = true;
            $http.get("http://a3.thedistantvoice.me/api/ClientAPI/GetReport/" + $scope.select.month + "/" + $scope.select.year)
            .success(function (response) {
                $scope.report = response;
                $scope.showResults = true;
            })
            .error(function (response) {
                alert("ERROR");
            });
            $scope.showReportLoading = false;
        }

        $scope.login = function () {
            $scope.loginError = "Logging in..."
            var data = "grant_type=password&" + "username=" + $scope.login.email + "&password=" + $scope.login.password;

            $http.post("http://a3.thedistantvoice.me/Token", data, {
                headers:
            { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function (response) {
                if (response.roles.indexOf("Administrator") > -1 ||
					response.roles.indexOf("Reporter") > -1) {
                    // $http.get("http://a3.thedistantvoice.me/api/ClientAPI/ReportLogin")
                    // .success(function (response) {
                    // if (response == "true") {
                    $scope.report = response;
                    $scope.showLogin = false;
                    $scope.showReport = true;
                    getYear();
                } else {
                    //alert(JSON.stringify(response));
                    $scope.loginError = "User is not authorized to view this page."
                }
                // })
                // .error(function (response) {
                // $scope.loginError = "Error checking authorization."
                // });

            }).error(function (error) {
                $scope.loginError = "Invalid login attempt."
            });
        }
    };

    app.controller("ReportController", ["$scope", "$http", ReportController]);

}());