using System.Collections.Generic;

namespace Personagem
{
    public class Classe
    {
        public int idClass { get; set; }
        public string nome { get; set; }
        public  string habilidade { get; set; }
        public Atributos atributos { get; set; }

        public Classe selecionarClasse(int id)
        {
            Classe classe = null;
    
            // seleciona e retorna a classe de acordo com o id enviado na requisição.
            switch (id)
            {
                case 1:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Detetive";
                    classe.habilidade = "Investigar(Percepção)\nInterrogar(Inteligência) ";
                    classe.atributos.agilidade = 0;
                    classe.atributos.destreza = 0;
                    classe.atributos.forca = 0;
                    classe.atributos.percepcao = 3;
                    classe.atributos.tecnologia = 0;
                    classe.atributos.inteligencia = 2;
                    classe.atributos.determinacao = 0;
                    classe.atributos.carisma = 0;
                    classe.atributos.hitPoints = 0;
                    break;
                case 2:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Oráculo";
                    classe.habilidade = "Hackear(Computação)/nMira High-Tec(Destreza/Computação)nFranco-Atirador ";
                    classe.atributos.agilidade = -1;
                    classe.atributos.destreza = 2;
                    classe.atributos.forca = -2;
                    classe.atributos.percepcao = 0;
                    classe.atributos.tecnologia = 3;
                    classe.atributos.inteligencia = 2;
                    classe.atributos.determinacao = 0;
                    classe.atributos.carisma = -2;
                    classe.atributos.hitPoints = -1;
                    break;
                case 3:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Mestre das explosões";
                    classe.habilidade = "Engenheiro destruidor(Inteligência)\nVeneno e Antídoto(Passivo)";
                    classe.atributos.agilidade = 1;
                    classe.atributos.destreza = 2;
                    classe.atributos.forca = 0;
                    classe.atributos.percepcao = 0;
                    classe.atributos.tecnologia = -3;
                    classe.atributos.inteligencia = 2;
                    classe.atributos.determinacao = -2;
                    classe.atributos.carisma = -2;
                    classe.atributos.hitPoints = 0;
                    break;
                case 4:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Assassino";
                    classe.habilidade = "Caminhar nas sombras\nMorte Silenciosa";
                    classe.atributos.agilidade = 2;
                    classe.atributos.destreza = 2;
                    classe.atributos.forca = -1;
                    classe.atributos.percepcao = 0;
                    classe.atributos.tecnologia = 0;
                    classe.atributos.inteligencia = 0;
                    classe.atributos.determinacao = 0;
                    classe.atributos.carisma = 0;
                    classe.atributos.hitPoints = 0;
                    break;
                 case 5:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Samurai";
                    classe.habilidade = "Katana(passivo)\nEscudo Cortante(Agilidade)\nImune a dor(Passivo)";
                    classe.atributos.agilidade = 1;
                    classe.atributos.destreza = 2;
                    classe.atributos.forca = 0;
                    classe.atributos.percepcao = 0;
                    classe.atributos.tecnologia = -10;
                    classe.atributos.inteligencia = 0;
                    classe.atributos.determinacao = 0;
                    classe.atributos.carisma = -2;
                    classe.atributos.hitPoints = 1;
                    break;
                 case 6:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Máquina de combate";
                    classe.habilidade = "Compactação(Passivo)\nArma discreta(destreza)\nAuto Munição(passivo)";
                    classe.atributos.agilidade = 1;
                    classe.atributos.destreza = 3;
                    classe.atributos.forca = 1;
                    classe.atributos.percepcao = 0;
                    classe.atributos.tecnologia = -3;
                    classe.atributos.inteligencia = -3;
                    classe.atributos.determinacao = 0;
                    classe.atributos.carisma = -3;
                    classe.atributos.hitPoints = 0;
                    break;
                 case 7:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Monstro de guerra";
                    classe.habilidade = "Frenesia\nTorreta(Destreza)";
                    classe.atributos.agilidade = -1;
                    classe.atributos.destreza = 1;
                    classe.atributos.forca = 1;
                    classe.atributos.percepcao = 0;
                    classe.atributos.tecnologia = 0;
                    classe.atributos.inteligencia = -1;
                    classe.atributos.determinacao = 0;
                    classe.atributos.carisma = -2;
                    classe.atributos.hitPoints = 0;
                    break;
                 case 8:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Mestre dos disfarces";
                    classe.habilidade = "Disfarce\n";
                    classe.atributos.agilidade = 2;
                    classe.atributos.destreza = -2;
                    classe.atributos.forca = -2;
                    classe.atributos.percepcao = 1;
                    classe.atributos.tecnologia = -2;
                    classe.atributos.inteligencia = 1;
                    classe.atributos.determinacao = 0;
                    classe.atributos.carisma = 3;
                    classe.atributos.hitPoints = 0;
                    break;
              
            }

            return classe;
        }

}
}