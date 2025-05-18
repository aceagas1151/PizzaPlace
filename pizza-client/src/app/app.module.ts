import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { OrdersComponent } from './components/orders/orders.component';
import { PizzaTypeListComponent } from './components/pizza-type-list/pizza-type-list.component';
import { routes } from './app.routes';

@NgModule({
  declarations: [
    AppComponent,
    OrdersComponent,
    PizzaTypeListComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes) 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
