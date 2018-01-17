import { APP } from "./index";

(function (a) {
  var success = function (res: any) {
    console.log('success');
    console.log(res);
  }

  var failure = function (res: any) {
    console.log('failure');
    console.log(res);
  }

  a.ajax('get', 'https://swapi.co/api/people/1', null, success, failure);

})(APP); // IIFE
