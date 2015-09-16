/*
var dlScanner = {
    scanBarcode: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "dlScanner", "scanBarcode", [strInput]);
    }
}
*/
// module.exports = dlScanner;

    $(document).ready(function () {
        $('#cmdOne').click(function () {
            dlScanner.scanBarcode(
                function (results) {
                    alert(results);
            }), function (err) {
                    alert(err);
            }, 'lowercaseworld'
        });
    });
