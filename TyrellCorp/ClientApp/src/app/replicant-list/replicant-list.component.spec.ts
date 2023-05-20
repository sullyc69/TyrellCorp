import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReplicantListComponent } from './replicant-list.component';

describe('ReplicantListComponent', () => {
  let component: ReplicantListComponent;
  let fixture: ComponentFixture<ReplicantListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReplicantListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReplicantListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
