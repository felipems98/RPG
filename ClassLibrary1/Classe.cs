using System.Collections.Generic;

namespace Personagem
{
    public class Classe
    {
        public int idClass { get; set; }
        public string nome { get; set; }
        public  string habilidade { get; set; }

        public List<Classe> selecionarClasse(int id)
        {
            Classe classe = null;
            var ret = new List<Classe>();
     
            switch (id)
            {
                case 1:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Detetive";
                    classe.habilidade = "Investigar(Percepção)\nInterrogar(Inteligência) ";
                    break;
                case 2:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Oráculo";
                    classe.habilidade = "Hackear(Computação)/nMira High-Tec(Destreza/Computação)nFranco-Atirador ";
                    break;
                case 3:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Mestre das explosões";
                    classe.habilidade = "Engenheiro destruidor(Inteligência)\nVeneno e Antídoto(Passivo)";
                    break;
                case 4:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Assassino";
                    classe.habilidade = "Caminhar nas sombras\nMorte Silenciosa";
                    break;
                 case 5:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Samurai";
                    classe.habilidade = "Katana(passivo)\nEscudo Cortante(Agilidade)\nImune a dor(Passivo)";
                    break;
                 case 6:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Máquina de combate";
                    classe.habilidade = "Compactação(Passivo)\nArma discreta(destreza)\nAuto Munição(passivo)";
                    break;
                 case 7:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Monstro de guerra";
                    classe.habilidade = "Frenesia\nTorreta(Destreza)";
                    break;
                 case 8:
                    classe = new Classe();
                    classe.idClass = id;
                    classe.nome = "Mestre dos disfarces";
                    classe.habilidade = "Disfarce\n";
                    break;
              
            }

            ret.Add(classe);
            return ret;
        }

}
}