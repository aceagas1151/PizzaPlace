import { Routes } from "@angular/router";
import { PizzaTypeListComponent } from "./components/pizza-type-list/pizza-type-list.component";

const routes: Routes = [
  { path: 'pizza-types', component: PizzaTypeListComponent },
  { path: '', redirectTo: '/pizza-types', pathMatch: 'full' }
];
