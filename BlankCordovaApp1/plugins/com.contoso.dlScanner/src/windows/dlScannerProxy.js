var cordova = require('cordova'),
    dlScanner= require('./dlScanner');

module.exports = {

    scanBarcode: function (successCallback, errorCallback, strInput) {

        //var upperCase = strInput[0].toUpperCase();
        //if(upperCase != "") {
        //    successCallback(upperCase);
        //}
        //else {
        //    errorCallback(upperCase);
        //}

        successCallback('snot');
    }
};

require("cordova/exec/proxy").add("dlScanner", module.exports);

