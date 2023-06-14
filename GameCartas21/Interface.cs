using GameCartas21.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCartas21.Properties;

namespace GameCartas21
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        Jogo jogo = new Jogo();

        private void btnJogar_Click(object sender, EventArgs e)
        {
            var result = jogo.Start();

            //Selecionando a imagem para o PictureBox
            mostraImagem(result.Item1.ValorDaCarta);

            btnParar.Visible = true;

            //Sempre mostrar o resultado do jogador
            labelResultJogador.Text = result.Item1.Resultado.ToString();

            //Só mostrar o resultado da máquina se o jogador perder
            if (result.Item1.Mensagem == "Perdeu")
            {
                labelRetorno.Text = "A máquina venceu!!!";
                labelResultCOM.Text = result.Item2.Resultado.ToString();
                lblScoreCOM.Text = result.Item3.ResultadoMaquina.ToString();
                btnParar.Visible = false;
                btnReiniciar.Visible = true;
                btnJogar.Visible = false;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            var result = jogo.Stop();

            if (result.Item1.Mensagem == "Perdeu")
            {
                labelRetorno.Text = "A máquina venceu!!!";
                labelResultCOM.Text = result.Item2.Resultado.ToString();
                lblScoreCOM.Text = result.Item3.ResultadoMaquina.ToString();
            }
            else
            {
                labelResultCOM.Text = result.Item2.Resultado.ToString();
                labelRetorno.Text = result.Item1.Mensagem;
                lblScoreJogador.Text = result.Item3.ResultadoHumano.ToString();
            }

            btnReiniciar.Visible = true;
            btnParar.Visible = false;
            btnJogar.Visible = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            jogo.Clear();
            labelRetorno.Text = "";
            labelResultJogador.Text = "0";
            labelResultCOM.Text = "CARTAS OCULTAS";
            pictureBox1.Image = Resources.fundo;
            btnParar.Visible = false;
            btnReiniciar.Visible = false;
            btnJogar.Visible = true;
        }

        private void mostraImagem(int resultado)
        {
            switch (resultado)
            {
                case 1:
                    pictureBox1.Image = Resources._as_carta_red;
                    break;
                case 2:
                    pictureBox1.Image = Resources._2_red;
                    break;
                case 3:
                    pictureBox1.Image = Resources._3_red;
                    break;
                case 4:
                    pictureBox1.Image = Resources._4_red;
                    break;
                case 5:
                    pictureBox1.Image = Resources._5_red;
                    break;
                case 6:
                    pictureBox1.Image = Resources._6_red;
                    break;
                case 7:
                    pictureBox1.Image = Resources._7_red;
                    break;
                case 8:
                    pictureBox1.Image = Resources._8_red;
                    break;
                case 9:
                    pictureBox1.Image = Resources._9_red;
                    break;
                case 10:
                    pictureBox1.Image = Resources._valet_carta_red;
                    break;
            }
        }

    }
}
