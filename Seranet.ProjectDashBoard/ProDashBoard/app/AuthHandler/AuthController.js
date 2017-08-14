﻿(function () {
    'use strict';
    //create angularjs controller

    app.controller('AuthController', ['$scope', 'toaster', '$mdDialog', '$rootScope', '$http', '$window', '$timeout', AuthController]);

    //angularjs controller method


    function AuthController($scope, toaster, $mdDialog, $rootScope, $http, $window, $timeout) {
       
        isAuthorized();

        //Chek authorization
        function isAuthorized() {
            $http.get('api/Authorization').success(function (data) {
                getEmployee(data);
            })
        .error(function () {
            $scope.error = "An Error has occured while loading posts!";
            $scope.loading = false;
        });
        }

        

        //Check the Admin level and Redirect to the page
        function isAdmin() {
            $http.get("api/Authorization/getAdminRights").success(function (data) {
                var isAdmin = data;
                $http.get("api/AppSettings/getCorporateDashboard").success(function (data2) {
                    if (isAdmin && data2) {
                        //window.location.replace("#/coHome");
                        window.location.replace("#/coHome");
                    } else {
                        window.location.replace("#/home");
                    }
                }).error(function () {
                });
            })
            .error(function () {
            });
        }


        function getEmployee(username) {
            $http.get('api/TeamMembers/' + username).success(function (data) {
                console.log(data);
                if (data != null | data != "") {
                    $scope.employee = data;
                    $scope.LoggedInUserName = "Seranet / " + data.MemberName;
                    $scope.loggedInUserId = data.Id;
                    isAdmin();
                }

            }).error(function () {
                $scope.error = "An Error has occured while loading posts!";
                $scope.loading = false;
        });
        }

    }

})();