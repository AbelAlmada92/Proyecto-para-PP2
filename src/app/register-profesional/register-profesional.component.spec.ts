import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterProfesionalComponent } from './register-profesional.component';

describe('RegisterProfesionalComponent', () => {
  let component: RegisterProfesionalComponent;
  let fixture: ComponentFixture<RegisterProfesionalComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RegisterProfesionalComponent]
    });
    fixture = TestBed.createComponent(RegisterProfesionalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
