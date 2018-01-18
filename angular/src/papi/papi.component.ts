import { Component } from "@angular/core";
import { PapiService } from "./papi.service";

@Component({
  selector: 'papi',
  templateUrl: 'papi.html',
  styleUrls: ['papi.css']
})
export class PapiComponent {
  hello = 'Pokemon API';

  service: PapiService;
  
  poke = {
    name: '',
    height: '',
    weight: ''
  };

  constructor(svc: PapiService) {
    this.service = svc;
  }

  showPoke() {
    var res: Promise<Object> = this.service.getPokemon();

    res.then(
      (r: any) => {
        this.poke.name = r.name;
        this.poke.height = r.height;
        this.poke.weight = r.weight;
      },
      (r: any) => {
        console.log(res);
      }
    )
  }
}
