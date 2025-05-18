import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrdersComponent } from './components/orders/orders.component';
import { PizzaTypeListComponent } from "./components/pizza-type-list/pizza-type-list.component";

const routes: Routes = [
  { path: 'orders', component: OrdersComponent },
  { path: 'pizzas', component: PizzaTypeListComponent },
  { path: '', redirectTo: '/orders', pathMatch: 'full' }, // default
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
