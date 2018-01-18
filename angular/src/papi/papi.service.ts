import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable()
export class PapiService {
  request: HttpClient;

  constructor(req: HttpClient) { 
    this.request = req;
  }

  getPokemon() {
    return this.request.get('https://pokeapi.co/api/v2/pokemon/1').toPromise();
  }
}
