import { Routes } from '@angular/router';
import { PizzaTypeListComponent } from './components/pizza-type-list/pizza-type-list.component';
import { OrdersComponent } from './components/orders/orders.component';

export const routes: Routes = [
  { path: 'orders', component: OrdersComponent },
  { path: 'pizza-types', component: PizzaTypeListComponent },
  { path: '', redirectTo: '/orders', pathMatch: 'full' }
];
