import { TestBed, inject } from '@angular/core/testing';

import { PapiService } from './papi.service';

describe('PapiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PapiService]
    });
  });

  it('should be created', inject([PapiService], (service: PapiService) => {
    expect(service).toBeTruthy();
  }));
});
