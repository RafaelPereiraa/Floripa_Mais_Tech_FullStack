import { TestBed } from '@angular/core/testing';

import { ApiexerciciosService } from './apiexercicios.service';

describe('ApiexerciciosService', () => {
  let service: ApiexerciciosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ApiexerciciosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
