var dlScanner = {
    scanBarcode: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "dlScanner", "scanBarcode", [strInput]);
    }
}

module.exports = dlScanner;
