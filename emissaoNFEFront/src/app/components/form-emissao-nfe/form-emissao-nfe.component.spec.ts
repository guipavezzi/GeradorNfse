import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormEmissaoNfeComponent } from './form-emissao-nfe.component';

describe('FormEmissaoNfeComponent', () => {
  let component: FormEmissaoNfeComponent;
  let fixture: ComponentFixture<FormEmissaoNfeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormEmissaoNfeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormEmissaoNfeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
