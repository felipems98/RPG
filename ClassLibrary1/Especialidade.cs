namespace Personagem
{
    public class Especialidade
    {
        public int idEsp { get; set; }
        public string nome { get; set; }

        public string setEspecialidade( int id )
        {
            Especialidade esp = null;

            switch (id)
            {
                case 1:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Pistoleiro";
                    break;
                case 2:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Destruidor";
                    break;
                case 3:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Lâmina Mortal";
                    break;
                case 4:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Guerreiro";
                    break;
                case 5:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Controle da Sorte";
                    break;
                case 6:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Mais munição";
                    break;
                case 7:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Experiente";
                    break;
                case 8:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Imortal";
                    break;
                case 9:
                    esp = new Especialidade();
                    esp.idEsp = id;
                    esp.nome = "Mais Conhecimento";
                    break;
            }

            return esp.nome;

        }
    }
}