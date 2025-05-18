import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { PizzaTypeService } from '../../services/pizza-type.service';
import { PizzaType } from '../../models/pizza-type';

@Component({
  selector: 'app-pizza-type-list',
  standalone: true,
  imports: [CommonModule, HttpClientModule], 
  templateUrl: './pizza-type-list.component.html'
})
export class PizzaTypeListComponent implements OnInit {

  pizzas: PizzaType[] = [];

  constructor(private pizzaTypeService: PizzaTypeService) {}

  ngOnInit(): void {
    this.pizzaTypeService.getPizzaTypes().subscribe({
      next: data => this.pizzas = data,
      error: err => console.error('Error fetching pizza types', err)
    });
  }
}
