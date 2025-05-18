import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { PizzaTypeListComponent } from './components/pizza-type-list/pizza-type-list.component';





@NgModule({
  declarations: [
    AppComponent,
    PizzaTypeListComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [PizzaTypeListComponent]
})
export class AppModule { }
