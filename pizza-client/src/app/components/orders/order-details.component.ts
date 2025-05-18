import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';
import { OrderService, Order } from '../../services/order.service';

@Component({
  selector: 'app-order-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-details.component.html'
})
export class OrderDetailsComponent implements OnInit {
  order: Order | null = null;
  isLoading = true;

  constructor(
    private route: ActivatedRoute,
    private orderService: OrderService
  ) {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    if (id) {
      this.orderService.getOrder(id).subscribe({
        next: (data) => {
          this.order = data;
          this.isLoading = false;
        },
        error: (err) => {
          console.error('Error fetching order:', err);
          this.isLoading = false;
        }
      });
    }
  }
}
