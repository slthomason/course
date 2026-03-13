import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GitUserListComponent } from './git-user-list.component';

describe('GitUserListComponent', () => {
  let component: GitUserListComponent;
  let fixture: ComponentFixture<GitUserListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GitUserListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GitUserListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
