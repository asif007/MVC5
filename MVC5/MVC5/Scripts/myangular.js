var aa=angular.module("app", []);
    aa.controller("First", function ($scope) {
    $scope.time = "fir";
    $scope.lastname = "ahmed";
});
    aa.controller("Second", function ($scope) {
        $scope.t1 = 10;
        $scope.t2 = 20;
        $scope.time = function () {
            return $scope.t1 * $scope.t2;
        }
    })
