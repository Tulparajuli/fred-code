"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var index_1 = require("./index");
var finder = document.querySelector('#finder');
var pass = function (res, el) {
    if (res) {
        var r = JSON.parse(res);
        var ul = document.createElement('ul');
        for (var i in r.results[0].films) {
            var li = document.createElement('li');
            li.innerHTML = i;
            ul.appendChild(li);
        }
        el.appendChild(ul);
    }
};
finder.addEventListener('click', function (event) {
    var searchItem = document.querySelector('#character').value;
    var ml = document.querySelector('#movielist');
    event.preventDefault();
    event.stopImmediatePropagation();
    index_1.APP.ajax('get', 'https://swapi.co/api/people?search=' + searchItem, null, function (rs) {
        pass(rs, ml);
    }, function (rs) {
        console.log(rs);
    });
});
