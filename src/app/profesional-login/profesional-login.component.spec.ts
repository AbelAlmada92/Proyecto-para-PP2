import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfesionalLoginComponent } from './profesional-login.component';

describe('ProfesionalLoginComponent', () => {
  let component: ProfesionalLoginComponent;
  let fixture: ComponentFixture<ProfesionalLoginComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ProfesionalLoginComponent]
    });
    fixture = TestBed.createComponent(ProfesionalLoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
