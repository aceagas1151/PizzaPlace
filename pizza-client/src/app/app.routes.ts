import { Routes } from '@angular/router';
import { PizzaTypeListComponent } from './components/pizza-type-list/pizza-type-list.component';
import { OrdersComponent } from './components/orders/orders.component';
import { OrderDetailsComponent } from './components/orders/order-details.component';
import { PizzaComponent } from './components/pizza/pizza.component';

export const routes: Routes = [
  { path: 'orders', component: OrdersComponent },
  { path: 'orders/:id', component: OrderDetailsComponent },
  { path: 'pizzas', component: PizzaComponent },
  { path: 'pizza-types', component: PizzaTypeListComponent },
  { path: '', redirectTo: '/orders', pathMatch: 'full' }
];
