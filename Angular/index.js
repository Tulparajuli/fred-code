(function () {
  var y = 10;

  Bar();

  function Foo() {
    //var y; // hoisted
    console.log(y);
    var y = 20;
  }

  console.log(y); // 10
  Foo(); // undefined

  //foo();

  var foo = function () {
    console.log("i am foo()");
  } // expression

  function Bar(params) {
    console.log("i am Bar()");
    //foo();
  } // statement

  var ajax = function (verb, url, data, pass, fail) {
    var xhr = new XMLHttpRequest();

    xhr.open(verb, url);

    xhr.onreadystatechange = function () {
      if (xhr.readyState == 4 && xhr.status == 200) {
        pass(xhr.response);
      } else if (xhr.readyState == 4) {
        fail(xhr.response);
      }
    }

    xhr.send();
  }

  var success = function (res) {
    console.log('success');
    console.log(res);
  }

  var failure = function (res) {
    console.log('failure');
    console.log(res);
  }

  ajax('get', 'https://swapi.co/api/people/1', null, success, failure);

})(); // IIFE
