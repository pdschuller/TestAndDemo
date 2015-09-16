var cordova = require('cordova'),
    pdsGenerated= require('./pdsGenerated');

module.exports = {

    generateThis: function (successCallback, errorCallback, strInput) {

        var upperCase = strInput[0].toUpperCase();
        if(upperCase != "") {
            successCallback(upperCase);
        }
        else {
            errorCallback(upperCase);
        }
    }
};

require("cordova/exec/proxy").add("pdsGenerated", module.exports);

