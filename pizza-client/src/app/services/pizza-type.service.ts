import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PizzaType } from '../models/pizza-type';

@Injectable({
  providedIn: 'root'
})
export class PizzaTypeService {
  private baseUrl = 'http://localhost:5001/api/PizzaTypes';

  constructor(private http: HttpClient) {}

  getPizzaTypes(): Observable<PizzaType[]> {
    return this.http.get<PizzaType[]>(this.baseUrl);
  }
}
