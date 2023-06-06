using System.ComponentModel.DataAnnotations;

namespace MCVGamer.Models
{
    public class Equipe
    {
        [Key] //DATA ANNOTATION - ID EQUIPE 
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        public ICollection<Jogador> Jogador { get; set; } //REFERENCIA A CLASSE EQUIPE VAI TER ACESSO A COLLETION JOGADORES (FOI INSTALADO PACOTES REFERENTES A FERRAMENTAS ENTITI FRAMEWORK(A PARTIR DO JOCODIO IRA GERAR A TABELA NO BANCO DE DADOS)).



    }
}