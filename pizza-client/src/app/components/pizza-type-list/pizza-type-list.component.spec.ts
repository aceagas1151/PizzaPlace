import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PizzaTypeListComponent } from './pizza-type-list.component';

describe('PizzaTypeListComponent', () => {
  let component: PizzaTypeListComponent;
  let fixture: ComponentFixture<PizzaTypeListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PizzaTypeListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PizzaTypeListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
