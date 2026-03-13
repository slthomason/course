import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelloWorldCliComponent } from './hello-world-cli.component';

describe('HelloWorldCliComponent', () => {
  let component: HelloWorldCliComponent;
  let fixture: ComponentFixture<HelloWorldCliComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HelloWorldCliComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HelloWorldCliComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
