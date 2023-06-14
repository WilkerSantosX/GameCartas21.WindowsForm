using GameCartas21.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCartas21
{
    public class Jogo
    {
        //Instancia das classes que serão usadas
        Jogador jogadorHumano = new Jogador();
        Jogador jogadorMaquina = new Jogador();
        FinalRodada score = new FinalRodada();

        Baralho cartas = new Baralho();
 

        /// <summary>
        /// Jogador pega as cartas
        /// </summary>
        /// <returns></returns>
        public Tuple<Jogador, Jogador, FinalRodada> Start()
        {
            //Tirar carta para o jogador humano
            Carta cartaTirada = cartas.TirarCarta();

            //Seta o resultado do jogador humano
            jogadorHumano.Resultado += cartaTirada.Valor;
            jogadorHumano.ValorDaCarta = cartaTirada.Valor;

            //Se a soma for maior que 21 pontos o jogador humano perde
            if (jogadorHumano.Resultado > 21)
            {
                jogadorHumano.Mensagem = "Perdeu";
                jogadorHumano.Resultado.ToString();
                score.ResultadoMaquina++; 
            }

            //Se o jogador humano não perdeu, a máquina decide se continuará
            if(string.IsNullOrEmpty(jogadorHumano.Mensagem))
            {
                Carta cartaTiradaCOM = cartas.TirarCarta();

                //Se tiver menos ponto do que o jogador humano e não ultrapassar 21 decide se continua ou para
                if (jogadorMaquina.Resultado < 21 && jogadorMaquina.Resultado < jogadorHumano.Resultado && jogadorHumano.Resultado < 21)
                {
                    jogadorMaquina.Resultado = AcaoMaquina();

                }
            }

           return Tuple.Create(jogadorHumano,jogadorMaquina,score);
        }

        /// <summary>
        /// Jogador para o jogo
        /// </summary>
        /// <returns></returns>
        public Tuple<Jogador, Jogador, FinalRodada> Stop()
        {
            //Se a máquina tiver menos ponto do que o jogador humano e não ultrapassar 21 ela decide se continua ou para
            if (jogadorMaquina.Resultado < 21 && jogadorMaquina.Resultado < jogadorHumano.Resultado && jogadorHumano.Resultado < 21)
                jogadorMaquina.Resultado = AcaoMaquina();

            //Verifica o ganhador do jogo, se o humano tiver mais pontos que a máquina e menos que 21
            if (jogadorHumano.Resultado > jogadorMaquina.Resultado && jogadorHumano.Resultado <= 21 || jogadorHumano.Resultado < jogadorMaquina.Resultado && jogadorMaquina.Resultado >= 21)
            {
                jogadorHumano.Mensagem = "Parabéns, você ganhou!";
                score.ResultadoHumano++;
            }

            //Verifica o ganhador do jogo, se o humano tiver menos pontos que a máquina e a máquina menos que 21
            else if (jogadorHumano.Resultado < jogadorMaquina.Resultado && jogadorMaquina.Resultado <= 21)
            {
                jogadorHumano.Mensagem = "Perdeu";
                score.ResultadoMaquina++;
            }

            else if (jogadorHumano.Resultado == jogadorMaquina.Resultado)
            {
                jogadorHumano.Mensagem = "Deu empate!";
            }


            return Tuple.Create(jogadorHumano, jogadorMaquina, score);
        }


        /// <summary>
        /// Ação de limpeza da memória
        /// </summary>
        /// <returns></returns>
        public void Clear()
        {
            cartas = new Baralho();
            jogadorHumano = new Jogador();
            jogadorMaquina = new Jogador();
        }


        /// <summary>
        /// Ação da Máquina
        /// </summary>
        /// <returns></returns>
        public int AcaoMaquina()
        {
            var decisao = new Random();
            var escolha = decisao.Next(0, 1);

            switch(escolha)
            {
                case 0:
                    Carta tirada = cartas.TirarCarta();
                    jogadorMaquina.Resultado += tirada.Valor;
                    break;
                case 1:
                    jogadorMaquina.Mensagem = "Parou";
                    break;
            }

  
            return jogadorMaquina.Resultado;
        }

    }
}
