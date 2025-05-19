import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PizzaService } from '../../services/pizza.service';
import { Pizza } from '../../models/pizza.model';

@Component({
  selector: 'app-pizza',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './pizza.component.html'
})
export class PizzaComponent implements OnInit {
  pizzas: Pizza[] = [];
  pagedPizzas: Pizza[] = [];

  currentPage = 1;
  pageSize = 4;

  constructor(private pizzaService: PizzaService) {}

  ngOnInit(): void {
    this.pizzaService.getPizzas().subscribe({
      next: data => {
        this.pizzas = data;
        this.updatePage();
      },
      error: err => console.error('Error loading pizzas', err)
    });
  }

  updatePage(): void {
    const startIndex = (this.currentPage - 1) * this.pageSize;
    const endIndex = startIndex + this.pageSize;
    this.pagedPizzas = this.pizzas.slice(startIndex, endIndex);
  }

  nextPage(): void {
    if (this.currentPage < this.totalPages) {
      this.currentPage++;
      this.updatePage();
    }
  }

  prevPage(): void {
    if (this.currentPage > 1) {
      this.currentPage--;
      this.updatePage();
    }
  }

  get totalPages(): number {
    return Math.ceil(this.pizzas.length / this.pageSize);
  }
}
