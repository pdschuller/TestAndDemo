var dlScanner = {
    scanBarcode: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "dlScanner", "scanBarcode", [strInput]);
    }
}

function onLoad() {
    document.addEventListener("deviceready", onDeviceReady, false);
}

function onDeviceReady() {
    // Now safe to use device APIs
    module.exports = dlScanner;
}


