var app = angular.module('myApp', []);
app.controller('myCtrl', function ($scope, $http) {

    $scope.groupList = [];

    $scope.getGroupList = function () {

        $http.get("http://localhost:55667/Group/list")
            .then(function (response) {

                angular.forEach(response.data, function (value, key) {
                    $scope.groupList.push(value);
                });
                //$scope.groupList = response.data;
            });

    };
});