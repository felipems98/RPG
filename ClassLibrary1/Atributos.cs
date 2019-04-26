using System.Collections.Generic;

namespace Personagem
{
    public class Atributos
    {
        public int agilidade { get; set; }
        public int destreza { get; set; }
        public int forca { get; set; }
        public int percepcao { get; set; }
        public int tecnologia { get; set; }
        public int inteligencia { get; set; }
        public int determinacao { get; set; }
        public int carisma { get; set; }
        public int hitPoints { get; set; }

        public Atributos setAtributos(int ag, int dt, int fc, int pp, int tc, int it, int det, int car, int hp)
        {
            var atributos = new Atributos();
            atributos.agilidade = ag;
            atributos.destreza = dt;
            atributos.forca = fc;
            atributos.percepcao = pp;
            atributos.tecnologia = tc;
            atributos.inteligencia = it;
            atributos.determinacao = det;
            atributos.carisma = car;
            hitPoints = hp;
            return atributos;

        }

    }
}