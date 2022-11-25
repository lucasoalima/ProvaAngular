import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number;
  selecaoA?: Selecao;
  SelecaoAid : Number;
  SelecaoBid : Number;
  selecaoB?: Selecao;
  criadoEm?: string;
  SelecaoAplacar? : string;
  SelecaoBplacar? : string;

}
