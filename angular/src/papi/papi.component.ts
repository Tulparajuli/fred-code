import { Component } from "@angular/core";
import { PapiService } from "./papi.service";

@Component({
  templateUrl: 'papi.html',
  styleUrls: ['papi.css']
})
export class PapiComponent {
  hello = 'Pokemon API';

  service: PapiService;

  poke = new Poke();

  constructor(svc: PapiService) {
    this.service = svc;
  }

  showPoke() {
    var res: Promise<Poke> = this.service.getPokemon() as Promise<Poke>;

    res.then(
      (r: any) => {
        this.poke = r;
      },
      (r: any) => {
        console.log(r);
      }
    )
  }

  showPoke2(res) {
    res.then(
      (r: any) => {
        this.poke = r;
      },
      (r: any) => {
        console.log(r);
      }
    );
  }
}

export class Poke {
  name: string;
  height: number;
  weight: number;
}
