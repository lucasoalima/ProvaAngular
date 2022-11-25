import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { Router } from "@angular/router";
import { Jogo } from "src/app/models/jogo.model";
import { Selecao } from "src/app/models/selecao.model";

@Component({
  selector: "app-cadastrar-jogo",
  templateUrl: "./cadastrar-jogo.component.html",
  styleUrls: ["./cadastrar-jogo.component.css"],
})
export class CadastrarJogoComponent implements OnInit {
  
  selecao1_id! : number;
  
  selecao2_id! : number;

  selecoes! : Selecao[];

  
  constructor(private http: HttpClient, private router: Router, private _snackBar: MatSnackBar) {}

  ngOnInit(): void {
    this.http
      .get<Selecao[]>("https://localhost:5001/api/selecao/listar")
      .subscribe({
        next: (selecoes) => {
          this.selecoes = selecoes;
        },
      });
  }

  cadastrar(): void {

    
    let jogo : Jogo = {
      SelecaoAid : this.selecao1_id,
      SelecaoBid : this.selecao2_id,
      
    };

    this.http.post<Jogo>("https://localhost:5001/api/jogo/cadastrar", jogo)
    .subscribe({
      next: (jogo) => {
        this.router.navigate(["pages/jogo/listar"]);
      },

    });
  }
}