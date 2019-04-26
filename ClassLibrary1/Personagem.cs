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
        public Especialidade  esp1 { get; set; }
        public Especialidade esp2 { get; set; }
        public Atributos att { get; set; }
        public string historia { get; set; }


    }

}
