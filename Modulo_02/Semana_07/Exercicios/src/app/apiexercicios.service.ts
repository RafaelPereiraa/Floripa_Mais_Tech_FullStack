import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiexerciciosService {
  private readonly apiUrl: string = environment.url;
  private readonly apiKey: string = environment.key;

  constructor(private http: HttpClient) {}

  getFilmes() {
    return this.http.get(`${this.apiUrl}/filmes/get-all`, {
      headers: {
        'x-api-key': this.apiKey,
      },
    });
  }
  
  getCursos() {
    return this.http.get(`${this.apiUrl}/cursos/get-all`, {
      headers: {
        'x-api-key': this.apiKey,
      },
    });
  }


}
