import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HogeComponent } from './hoge.component';

describe('HogeComponent', () => {
  let component: HogeComponent;
  let fixture: ComponentFixture<HogeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HogeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HogeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
