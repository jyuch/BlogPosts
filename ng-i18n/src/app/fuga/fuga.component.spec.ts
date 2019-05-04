import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FugaComponent } from './fuga.component';

describe('FugaComponent', () => {
  let component: FugaComponent;
  let fixture: ComponentFixture<FugaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FugaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FugaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
