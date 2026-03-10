import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateDrivenExampleComponent } from './template-driven-example.component';

describe('TemplateDrivenExampleComponent', () => {
  let component: TemplateDrivenExampleComponent;
  let fixture: ComponentFixture<TemplateDrivenExampleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemplateDrivenExampleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TemplateDrivenExampleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
