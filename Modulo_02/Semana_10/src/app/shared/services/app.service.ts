import { Injectable } from "@angular/core";
import { Comida } from "../models/comida";
import { Bebida } from "../models/bebida";
import { COMIDAS_MOCK } from "../mock/mock-comidas";
import { BEBIDAS_MOCK } from "../mock/mock-bebidas";
import { Observable, delay, of } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: "root",
})
export class AppService {
  comidaLista: Comida[] = COMIDAS_MOCK;
  bebidasLista: Bebida[] = BEBIDAS_MOCK;

  constructor(private http: HttpClient) {}

  getComidas(): Observable<Comida[]> {
    return this.http.get<Comida[]>("http://localhost:3000/comidas");
    // return of(this.comidaLista).pipe(delay(5000)); // chamada API
  }

  getBebidas(): Observable<Bebida[]> {
    return this.http.get<Comida[]>("http://localhost:3000/bebidas");
    // return of(this.bebidasLista); // chamada API
  }

  postBebida(bebida: Bebida): Observable<void> {
    return this.http.post<void>("http://localhost:3000/bebidas", bebida);
  }
}