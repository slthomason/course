import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomObsersablesComponent } from './custom-obsersables.component';

describe('CustomObsersablesComponent', () => {
  let component: CustomObsersablesComponent;
  let fixture: ComponentFixture<CustomObsersablesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustomObsersablesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomObsersablesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
