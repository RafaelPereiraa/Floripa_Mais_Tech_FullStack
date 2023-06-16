import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

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
  nome: string = '';
  email: string = '';
  nomeFilme: string = '';
  nota: number = 0;
  formFilme: FormGroup;

  constructor() {
    this.formFilme = new FormGroup({
      nome: new FormControl(''),
      email: new FormControl(''),
      nomeFilme: new FormControl(''),
      nota: new FormControl('')
    });
  }

  onSubmit(){
    alert(`Voce avaliou o filme ${this.nomeFilme}!`);
  }


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
