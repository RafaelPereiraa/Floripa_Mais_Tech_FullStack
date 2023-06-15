import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  texto: string = 'teste';
  numero01: number = 0;
  numero02: number = 0;
  resultado: number | undefined;

  somar(){
    this.resultado = this.numero01 + this.numero02;
  }

  subtrair(){
    this.resultado = this.numero01 - this.numero02;
  }

  multiplicar(){
    this.resultado = this.numero01 * this.numero02;
  }

  dividir(){
    this.resultado = this.numero01 / this.numero02;
  }

  limpar(){
    this.numero01 = 0;
    this.numero02 = 0;
    this.resultado = undefined;
  }
  
}
