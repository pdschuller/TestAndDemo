var pdsGenerated = {
    generateThis: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "pdsGenerated", "generateThis", [strInput]);
    }
}

module.exports = pdsGenerated;
