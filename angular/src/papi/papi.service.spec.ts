import { TestBed, inject } from '@angular/core/testing';

import { PapiService } from './papi.service';
import { HttpClientModule } from '@angular/common/http';

describe('PapiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PapiService],
      imports: [HttpClientModule]
    });
  });

  it('should be created', inject([PapiService], (service: PapiService) => {
    expect(service).toBeTruthy();
  }));
});
