import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReplicantsComponent } from './replicants.component';

describe('ReplicantsComponent', () => {
  let component: ReplicantsComponent;
  let fixture: ComponentFixture<ReplicantsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReplicantsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReplicantsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
