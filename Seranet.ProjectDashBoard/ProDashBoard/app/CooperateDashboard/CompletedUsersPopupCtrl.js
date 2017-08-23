(function () {
    'use strict';
    //create angularjs controller

    app.controller('CompletedUsersPopupCtrl', ['$scope', '$rootScope', '$http', '$modalInstance', 'Year', 'TeamData', 'Accounts', CompletedUsersPopupCtrl]);

    //angularjs controller method
    function CompletedUsersPopupCtrl($scope, $rootScope, $http, $modalInstance, Year, TeamData,Accounts) {
        console.log(TeamData);
        $scope.Accounts = Accounts;
        $scope.Time = Year;
        $scope.TeamData = TeamData;
        $scope.SelctProj = "All Accounts";
       

        $scope.close = function () {
            $modalInstance.dismiss('cancel');
        };

        $scope.change = function (name) {
            $scope.TeamData = [];
            TeamData.forEach(function (project) {
                if ((project.Account == name || name == "All Accounts")) {
                    $scope.TeamData.push(project);
                }
            });
        }

    }
})();