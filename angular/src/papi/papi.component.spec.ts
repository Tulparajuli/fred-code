import { PapiComponent } from "./papi.component";
import { TestBed, async } from "@angular/core/testing";
import { PapiService } from "./papi.service";
import { HttpClientModule } from "@angular/common/http";

describe('papi should do', () => {
  describe('hello', () => {
    beforeEach(() => {
      TestBed.configureTestingModule({
        declarations: [
          PapiComponent
        ],
        imports: [HttpClientModule],
        providers: [PapiService]
      }).compileComponents();
    });

    it('should say hello', () => {
      var sub: PapiComponent = TestBed.createComponent(PapiComponent).debugElement.componentInstance;
      expect(sub.hello).toEqual('Pokemon API');
    });

    it('should say pokemon', () => {
      var sub2: PapiComponent = TestBed.createComponent(PapiComponent).componentInstance;
      var sub1: PapiService = sub2.service;
      var r;

      var p = new Promise((p, f) => {
        r = sub1.getPokemon();
        sub2.showPoke2(r);

        r.then(() => {
          p();
        });
      }).then(() => {
        expect(sub2.poke.name).not.toBeNull();
        expect(sub2.poke.name).toBe('bulbasaur');
      });
    });
  });
});
