(function () {
    'use strict';
    //create angularjs controller

    app.controller('BurningIssuesPopupCtrl', ['$scope', '$rootScope', '$http', '$modalInstance', 'Year', 'TeamData', 'Accounts', BurningIssuesPopupCtrl]);

    //angularjs controller method
    function BurningIssuesPopupCtrl($scope, $rootScope, $http, $modalInstance, Year, TeamData, Accounts) {
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