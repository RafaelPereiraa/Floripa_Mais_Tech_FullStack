import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EsqueciSenhaComponent } from './esquecisenha.component';

describe('EsquecisenhaComponent', () => {
  let component: EsqueciSenhaComponent;
  let fixture: ComponentFixture<EsqueciSenhaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EsqueciSenhaComponent]
    });
    fixture = TestBed.createComponent(EsqueciSenhaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
