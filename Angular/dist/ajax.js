"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var index_1 = require("./index");
(function (a) {
    var success = function (res) {
        console.log('success');
        console.log(res);
    };
    var failure = function (res) {
        console.log('failure');
        console.log(res);
    };
    a.ajax('get', 'https://swapi.co/api/people/1', null, success, failure);
})(index_1.APP); // IIFE
