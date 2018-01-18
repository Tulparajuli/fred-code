import { APP as client } from "./index";

var finder = document.querySelector('#finder')!;
var pass = function (res: any, el: any) {
  if (res) {
    var r = JSON.parse(res);
    var ul = document.createElement('ul');

    for(var i in r.results[0].films) {
      var li = document.createElement('li');

      li.innerHTML = i;
      ul.appendChild(li);
    }

    el.appendChild(ul);
  }
}

finder.addEventListener('click', function (event) {
  var searchItem = (document.querySelector('#character') as HTMLInputElement).value;
  var ml = document.querySelector('#movielist');

  event.preventDefault();
  event.stopImmediatePropagation();

  client.ajax(
    'get', 
    'https://swapi.co/api/people?search=' + searchItem, 
    null, 
    (rs: any) => {
      pass(rs, ml);
    }, 
    (rs: any) => {
      console.log(rs);
    }
  );
});
