using System;

namespace API_Copa.Models
{
    public class Jogo
    {
        public Jogo()
        {
            CriadoEm = DateTime.Now;
        }
        public int Id { get; set; }

        public int SelecaoAid {get; set;}

        public Selecao SelecaoA { get; set; }

        public int SelecaoBid {get; set;}

        public Selecao SelecaoB { get; set; }

        public string SelecaoAplacar {get; set;}

        public string SelecaoBplacar {get; set;}
        
        public DateTime CriadoEm { get; set; }
    }
}