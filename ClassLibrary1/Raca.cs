namespace Personagem
{
   public class Raca
    {
        public int idRaca { get; set; }
        public string nome { get; set; }
        public string habilidades { get; set; }
        public Atributos atributos { get; set; }
        public Raca selecionaRaca(int id)
        {
            Raca raca = null;

            // seleciona e retorna a raca de acordo com o id enviado na requisição.
            switch (id)
            {
                case 1:
                    raca = new Raca();
                    raca.idRaca = id;
                    raca.nome = "Humano";
                    raca.atributos.agilidade = 3;
                    raca.atributos.destreza = 3;
                    raca.atributos.forca = 2;
                    raca.atributos.percepcao = 3;
                    raca.atributos.tecnologia = 3;
                    raca.atributos.inteligencia = 2;
                    raca.atributos.determinacao = 4;
                    raca.atributos.carisma = 3;
                    raca.atributos.hitPoints = 10;
                    raca.habilidades = "Autodidata";


                    break;
                case 2:
                    raca = new Raca();
                    raca.idRaca = id;
                    raca.nome = "Android";
                    raca.atributos.agilidade = 2;
                    raca.atributos.destreza =4 ;
                    raca.atributos.forca = 3;
                    raca.atributos.percepcao = 2;
                    raca.atributos.tecnologia = 4;
                    raca.atributos.inteligencia = 3;
                    raca.atributos.determinacao = 0;
                    raca.atributos.carisma = 2;
                    raca.atributos.hitPoints = 12;
                    raca.habilidades = "Auto-Reparo";
                    break;

                case 3:
                    raca = new Raca();
                    raca.idRaca = id;
                    raca.nome = "Modificação Raio";
                    raca.atributos.agilidade = 5;
                    raca.atributos.destreza = 5;
                    raca.atributos.forca = 2;
                    raca.atributos.percepcao = 4;
                    raca.atributos.tecnologia = 0;
                    raca.atributos.inteligencia = 2;
                    raca.atributos.determinacao = 2;
                    raca.atributos.carisma = 1;
                    raca.atributos.hitPoints = 8;
                    raca.habilidades = "Fator Surpresa";
                    break;

                case 4:
                    raca = new Raca();
                    raca.idRaca = id;
                    raca.nome = "Modificação Montanha";
                    raca.atributos.agilidade = 1;
                    raca.atributos.destreza = 2;
                    raca.atributos.forca = 5;
                    raca.atributos.percepcao = 1;
                    raca.atributos.tecnologia = 0;
                    raca.atributos.inteligencia = 1;
                    raca.atributos.determinacao = 5;
                    raca.atributos.carisma = 2;
                    raca.atributos.hitPoints = 16;
                    raca.habilidades = "Resistencia";
                    break;
                case 5:
                    raca = new Raca();
                    raca.idRaca = id;
                    raca.nome = "Modificação Psicose";
                    raca.atributos.agilidade = 2;
                    raca.atributos.destreza = 2;
                    raca.atributos.forca = 1;
                    raca.atributos.percepcao = 4;
                    raca.atributos.tecnologia = 0;
                    raca.atributos.inteligencia = 4;
                    raca.atributos.determinacao = 3;
                    raca.atributos.carisma = 3;
                    raca.atributos.hitPoints = 6;
                    raca.habilidades = "Induzir";
                    break;
            }

            return raca;
        }
    }
}