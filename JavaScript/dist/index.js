"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var APP = (function () {
    var ajax = function (verb, url, data, pass, fail) {
        var xhr = new XMLHttpRequest(); // provided by browser
        xhr.open(verb, url);
        xhr.onreadystatechange = function () {
            if (xhr.readyState == 4 && xhr.status == 200) {
                pass(xhr.response);
            }
            else if (xhr.readyState == 4) {
                fail(xhr.response);
            }
        };
        xhr.send();
        //console.log('hello ajax');
    };
    return {
        ajax: ajax
    };
})();
exports.APP = APP;
