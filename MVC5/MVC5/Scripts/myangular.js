(function () {

    var aa = angular.module("app", ["ngRoute"]);
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
    });
    aa.controller("products", function ($scope) {
        this.product = list;
    });
    var list = {
        Name: 'Mango',
        Price: 100,
        Item: 1000,
        Sold:true
    }
    aa.controller("PanelController", function () {
        this.product = list;
        this.tab = 1;
        this.selectTab = function (setTab) {
            this.tab = setTab;
        }
        this.isSelected = function (checkTab) {
            this.tab === checkTab;
        }
    });
    


})();