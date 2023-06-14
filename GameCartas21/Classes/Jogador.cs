using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCartas21.Classes
{
    public class Jogador
    {
        public int Resultado { get; set; }
        public int ValorDaCarta { get; set; }
        public string Mensagem { get; set; }
    }

    public class FinalRodada
    {
        public int ResultadoHumano { get; set; }
        public int ResultadoMaquina { get; set; }
    }



}
