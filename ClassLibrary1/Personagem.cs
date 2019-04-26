using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personagem
{
    public class Personagem
    {
        public string nome { get; set; }
        public Raca raca { get; set; }
        public Classe classe { get; set; }
        public string  esp1 { get; set; }
        public string esp2 { get; set; }
        public Atributos att { get; set; }
        public string historia { get; set; }

        public Personagem criarPersonagem(string nm, int idRaca, int idClasse, int idEsp1, int idEsp2, string hist)
        {
            var per = new Personagem();
            var consR = new Raca();
            var consC = new Classe();
            var consA = new Atributos();
            var consE = new Especialidade();
            int agi;
            int dest;
            int forca;
            int perc;
            int tecno;
            int intel;
            int deter;
            int car;
            int hp;



            //Definoe nome, raça, classe, especialidades e historia do personagem.
            per.nome = nm;
            per.raca = consR.selecionaRaca(idRaca);
            per.classe = consC.selecionarClasse(idClasse);
            per.esp1 = consE.selecionarEspecialidade(idEsp1);
            per.esp2 = consE.selecionarEspecialidade(idEsp2);
            per.historia = hist;
            ////////////////////////////////////////////////////////////////////////////////////////////
            //definir os atributos do personagem somando os atributos da classe com os atributos da raça
            agi = per.raca.atributos.agilidade + per.classe.atributos.agilidade;
            dest = per.raca.atributos.destreza + per.classe.atributos.destreza;
            forca = per.raca.atributos.forca + per.classe.atributos.forca;
            perc = per.raca.atributos.percepcao + per.classe.atributos.percepcao;
            tecno = per.raca.atributos.tecnologia + per.classe.atributos.tecnologia;
            intel = per.raca.atributos.inteligencia + per.classe.atributos.inteligencia;
            deter = per.raca.atributos.determinacao + per.classe.atributos.determinacao;
            car = per.raca.atributos.carisma + per.classe.atributos.carisma;
            hp = per.raca.atributos.hitPoints + per.classe.atributos.hitPoints;
            per.att = consA.setAtributos(agi, dest, forca, perc, tecno, intel, deter, car, hp);
            ///////////////////////////////////////////////////////////////////////////////////////////////
            return per;
        }




        /*
         * //Busca e define a raça do personagem
        public Raca setRaca(int id)
        {
            var cons = new Raca();
            var ret = cons.selecionaRaca(id);
            return ret;
        }
        
        //Busca e definie a classe do personagem
        public Classe setClasse(int id)
        {
            var cons = new Classe();
            var ret = cons.selecionarClasse(id);
            return ret;            
        }

        //Define as especialidades do personagem
        public string setEsp1(int id)
        {
            var cons = new Especialidade();
            esp1 = cons.selecionarEspecialidade(id);
            return esp1;
        }
        public string setEsp2(int id)
        {
            var cons = new Especialidade();
            esp2 = cons.selecionarEspecialidade(id);
            return esp1;
        }
       
        public Personagem retper()
        {
            var cons = Personagem();
            return cons;
        }*/


    }


}
