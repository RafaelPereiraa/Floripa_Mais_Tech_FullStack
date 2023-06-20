import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ApiexerciciosService } from '../apiexercicios.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  texto: string = 'teste';
  numero01: number = 0;
  numero02: number = 0;
  resultado: number | undefined;
  filmes: any[] = [];
  private subscription!: Subscription;
  showModal = false;
  loading = false;

  formFilme: FormGroup;

  constructor(private apiexerciciosService: ApiexerciciosService) {
    this.formFilme = new FormGroup({
      nome: new FormControl('', [Validators.required, Validators.minLength(3)]),
      email: new FormControl('', [Validators.required, Validators.email]),
      nomeFilme: new FormControl('', [
        Validators.required,
        Validators.minLength(3),
      ]),
      nota: new FormControl(''),
    });
  }

  // getFilmes() {
  //   this.apiexerciciosService.getFilmes().subscribe(
  //     {
  //       next: (filmesApi: any) => {
  //         this.filmes = filmesApi;
  //         console.log(this.filmes);
  //       },
  //       error: (error: any) => {
  //         console.log(error);
  //       }
  //     }
  //   );
  // }

  getCursos() {
    this.showModal = true;
    this.loading = true;
    this.apiexerciciosService.getCursos().subscribe({
      next: (cursosApi: any) => {
        let cursos = cursosApi;
        console.log(cursos);
      },
      error: (error: any) => {
        console.log(error);
      },
      complete: () => {
        console.log('Requisição completa!');
        this.loading = false;
        this.showModal = false;
      },
    });
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  onSubmit() {
    if (this.formFilme.invalid) {
      let mensagem: string = 'Formulário inválido!\n';
      if (this.formFilme.get('nome')?.errors) {
        mensagem += 'Nome é obrigatório e precisa ter mais que 3 caracteres!\n';
      }
      if (this.formFilme.get('email')?.errors) {
        mensagem += 'Email não preenchido ou em formato incorreto!\n';
      }
      if (this.formFilme.get('nomeFilme')?.errors) {
        mensagem +=
          'Nome do filme é obrigatório e precisa ter mais que 3 caracteres!';
      }
      alert(mensagem);
      return;
    }
    alert(`Voce avaliou o filme ${this.formFilme}!`);
  }

  somar() {
    this.resultado = this.numero01 + this.numero02;
  }

  subtrair() {
    this.resultado = this.numero01 - this.numero02;
  }

  multiplicar() {
    this.resultado = this.numero01 * this.numero02;
  }

  dividir() {
    this.resultado = this.numero01 / this.numero02;
  }

  limpar() {
    this.numero01 = 0;
    this.numero02 = 0;
    this.resultado = undefined;
  }

  async getAlunos() {
    const resposta = await fetch(
      'https://37aa4cce-9e6c-4ba1-89fa-c22aca00c2f6.mock.pstmn.io/alunos/get-all'
    );
    const alunos = await resposta.json();
    console.log(alunos);
  }

  
}
