import { Routes } from '@angular/router';
import { PizzaTypeListComponent } from './components/pizza-type-list/pizza-type-list.component';
import { OrdersComponent } from './components/orders/orders.component';
import { OrderDetailsComponent } from './components/orders/order-details.component';

export const routes: Routes = [
  { path: 'orders', component: OrdersComponent },
  { path: 'orders/:id', component: OrderDetailsComponent },
  { path: 'pizza-types', component: PizzaTypeListComponent },
  { path: '', redirectTo: '/orders', pathMatch: 'full' }
];
