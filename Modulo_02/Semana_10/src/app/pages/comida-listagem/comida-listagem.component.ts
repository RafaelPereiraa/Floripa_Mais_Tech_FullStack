import { Component, OnInit } from "@angular/core";
import { Comida } from "src/app/shared/models/comida";
import { AppService } from "src/app/shared/services/app.service";

@Component({
  selector: "nfd-comida-listagem",
  templateUrl: "./comida-listagem.component.html",
  styleUrls: ["./comida-listagem.component.scss"],
})
export class ComidaListagemComponent implements OnInit {
  comidaLista: Comida[] = [];
  mensagem = "Não foi encontrado registros";

  constructor(private comidaService: AppService) {}

  ngOnInit(): void {
    this.mensagem = "Carregando...";
    this.comidaService.getComidas().subscribe((result) => {
      console.log("result", result);
      this.comidaLista = result;
    });
  }
}