import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

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

  formFilme: FormGroup;

  constructor() {
    this.formFilme = new FormGroup({
      nome: new FormControl('',Validators.required),
      email: new FormControl('',[Validators.required, Validators.email]),
      nomeFilme: new FormControl('',Validators.required),
      nota: new FormControl('')
    });
  }

  onSubmit(){
    if(this.formFilme.invalid){
      this.formFilme.get('nome')?.errors ? alert('Nome é obrigatório!') : alert(`Obrigado ${this.formFilme.get('nome')?.value}!`);
      this.formFilme.get('email')?.errors ? alert('Email é obrigatório!') : alert(`Obrigado ${this.formFilme.get('email')?.value}!`);
      this.formFilme.get('nomeFilme')?.errors ? alert('Nome do filme é obrigatório!') : alert(`Obrigado ${this.formFilme.get('nomeFilme')?.value}!`);
      alert('Formulário inválido!');
      return;
    }
    alert(`Voce avaliou o filme ${this.formFilme}!`);
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
