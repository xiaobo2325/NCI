///创建人:肖国栋
///创建日期:2016-02-20
///说明:亲属通讯录管理
angular.module("sltcApp")
.controller('contactCtrl', ['$rootScope', '$scope', '$state', 'relationDtlRes', function ($rootScope, $scope, $state, relationDtlRes) {

    var loadData = function () {
        if (!$scope.person.RelationDtls) {
            $scope.person.RelationDtls = [];
            if (!!$scope.person.FeeNo) {
                relationDtlRes.get({ feeNo: $scope.person.FeeNo, currentPage: 1, pageSize: 10 }, function (data) {
                    angular.copy(data.Data, $scope.person.RelationDtls);
                });
            }
        }
    }
    $scope.init = function () {
         //$scope.$on("dataLoaded", function () {
         //       $scope.person = $scope.$parent.person;
         //   });
        //$scope.Contact = relativeRes.query();
        loadData();
    }

    $scope.$on('LoadTabData', function (data) {
        loadData();
    });

    $scope.currentItem = null;

    $scope.deleteItem = function (item) {
        //item.$delete().then(function () {
        $scope.person.RelationDtls.splice($scope.person.RelationDtls.indexOf(item), 1);
        //});
    };

    $scope.createItem = function (item) {
        //new relativeRes(item).$save().then(function (newItem) {
        //    $scope.Contact.push(newItem);
        //});
        $scope.person.RelationDtls.push(item);
    };

    $scope.updateItem = function (item) {
        item.UpdateDate = new Date().currentTime();
        //item.$save();
    };

    $scope.PostCodeSelected = function (item) {
        $scope.currentItem.Zip1 = item.PostCode;
        $scope.currentItem.Address = item.City;
        $scope.currentItem.Address2 = item.Town;
    }
    $scope.edit = function (item) {
        $scope.currentItem = item ? item : {};
        $scope.currentItemCopy = {};
        angular.copy($scope.currentItem, $scope.currentItemCopy);
        $("#relativeModal").modal("toggle");
    };
    $scope.create = function () {
        $scope.currentItem = {};
        $scope.currentItemCopy = {};
        angular.copy($scope.currentItem, $scope.currentItemCopy);
        $("#relativeModal").modal("toggle");
    };

    $scope.cancelEdit = function () {
        //console.log(1);
        //还原
        //if ($scope.currentItem && $scope.currentItem.$get) {
        //    $scope.currentItem.$get();
        //}
        angular.copy($scope.currentItemCopy, $scope.currentItem);
        $scope.currentItem = {};
        $("#relativeModal").modal("toggle");
    };

    $scope.saveEdit = function (item) {
        if (angular.isDefined(item.$$hashKey)) {
            $scope.updateItem(item);
        } else {
            $scope.createItem(item);
        }
        $("#relativeModal").modal("toggle");

    };
    $scope.changeName = function () {
        if ($scope.currentItem.Name.length === 0) {
            $scope.invalidStyle={'background-color': '#eed3d7'};
        } else {
            $scope.invalidStyle = {};
        }
    };

    //员工选择框回调函数
    $scope.staffSelected = function (item) {
        $scope.currentItem.CreateBy = item.EmpNo;
    }


    $scope.init();
}]);