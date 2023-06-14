using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCartas21.Classes
{
    public class Baralho
    {
        //Lista de cartas
        public List<Carta> Cartas { get; private set; }

        //Construtor do baralho
        public Baralho()
        {
            //Instancia a partir do construtor
            Cartas = new List<Carta>();

            //Add os naipes das cartas
            var naipes = new string[] {"Paus","Copas","Espadas","Ouros"};

            foreach (var naipe in naipes)
            {
                //Limitando o naipe em cartas de 2 a 10 e as criando
                for (int i = 2; i <= 10; i++)
                {
                    Cartas.Add(new Carta
                    {
                        Valor = i,
                        ValorImg = "red_"+ i.ToString(),
                        Naipe = naipe
                    });
                }

                //Criando um As
                Cartas.Add(new Carta
                {
                    Valor = 1,
                    ValorImg = "as_carta_red",
                    Naipe = naipe
                });

                //Criando um Vallet
                Cartas.Add(new Carta
                {
                    Valor = 10,
                    ValorImg = "_valet_carta_red",
                    Naipe = naipe
                });

                //Criando um Rei
                Cartas.Add(new Carta
                {
                    Valor = 10,
                    ValorImg = "_rei_carta_red",
                    Naipe = naipe
                });

                //Criando uma Dama
                Cartas.Add(new Carta
                {
                    Valor = 10,
                    ValorImg = "_dama_carta_red",
                    Naipe = naipe
                });
            }

        }

        //Método de interação no jogo
        public Carta TirarCarta(int qtde = 1)
        {
            var rnd = new Random();

            var pos = rnd.Next(0, Cartas.Count());
            var carta = Cartas.ElementAt(pos);
            Cartas.RemoveAt(pos);

            return carta;
        }

        //Método de Reiniciar os valores da classe
        public Baralho Reiniciar()
        {
            Baralho cartas = new Baralho();
            return cartas;
        }

    }
}
