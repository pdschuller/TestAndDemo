var dlScanner = {
    scanBarcode: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "dlScanner", "scanBarcode", [strInput]);
    }
}

// NOTE: THIS IS NOT THE FILE THAT RUNS. SEE THE www/scripts directory
function onLoad() {
    document.addEventListener("deviceready", onDeviceReady, false);
}

// device APIs are available
//
function onDeviceReady() {
    // Now safe to use device APIs
    module.exports = dlScanner;
}




