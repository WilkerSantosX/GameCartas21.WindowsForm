namespace GameCartas21
{
    partial class Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelResultJogador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJogador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelResultCOM = new System.Windows.Forms.Label();
            this.labelCOM = new System.Windows.Forms.Label();
            this.labelRetorno = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScoreJogador = new System.Windows.Forms.Label();
            this.lblScoreCOM = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResultJogador
            // 
            this.labelResultJogador.AutoSize = true;
            this.labelResultJogador.Location = new System.Drawing.Point(24, 10);
            this.labelResultJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultJogador.Name = "labelResultJogador";
            this.labelResultJogador.Size = new System.Drawing.Size(13, 13);
            this.labelResultJogador.TabIndex = 0;
            this.labelResultJogador.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelResultJogador);
            this.panel1.Location = new System.Drawing.Point(18, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 33);
            this.panel1.TabIndex = 6;
            // 
            // labelJogador
            // 
            this.labelJogador.AutoSize = true;
            this.labelJogador.Location = new System.Drawing.Point(18, 33);
            this.labelJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJogador.Name = "labelJogador";
            this.labelJogador.Size = new System.Drawing.Size(48, 13);
            this.labelJogador.TabIndex = 5;
            this.labelJogador.Text = "Jogador:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelResultCOM);
            this.panel2.Location = new System.Drawing.Point(18, 147);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 33);
            this.panel2.TabIndex = 8;
            // 
            // labelResultCOM
            // 
            this.labelResultCOM.AutoSize = true;
            this.labelResultCOM.Location = new System.Drawing.Point(21, 9);
            this.labelResultCOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultCOM.Name = "labelResultCOM";
            this.labelResultCOM.Size = new System.Drawing.Size(103, 13);
            this.labelResultCOM.TabIndex = 1;
            this.labelResultCOM.Text = "CARTAS OCULTAS";
            // 
            // labelCOM
            // 
            this.labelCOM.AutoSize = true;
            this.labelCOM.Location = new System.Drawing.Point(18, 118);
            this.labelCOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCOM.Name = "labelCOM";
            this.labelCOM.Size = new System.Drawing.Size(59, 13);
            this.labelCOM.TabIndex = 7;
            this.labelCOM.Text = "User COM:";
            // 
            // labelRetorno
            // 
            this.labelRetorno.AutoSize = true;
            this.labelRetorno.Location = new System.Drawing.Point(16, 334);
            this.labelRetorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRetorno.Name = "labelRetorno";
            this.labelRetorno.Size = new System.Drawing.Size(0, 13);
            this.labelRetorno.TabIndex = 11;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(17, 229);
            this.btnParar.Margin = new System.Windows.Forms.Padding(2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(88, 24);
            this.btnParar.TabIndex = 10;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Visible = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(18, 195);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(88, 24);
            this.btnJogar.TabIndex = 9;
            this.btnJogar.Text = "Pegar Carta";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Carta Tirada:";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(17, 261);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(88, 24);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar Jogo";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameCartas21.Properties.Resources.fundo;
            this.pictureBox1.Location = new System.Drawing.Point(249, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vencedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jogador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "User COM:";
            // 
            // lblScoreJogador
            // 
            this.lblScoreJogador.AutoSize = true;
            this.lblScoreJogador.Location = new System.Drawing.Point(298, 320);
            this.lblScoreJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreJogador.Name = "lblScoreJogador";
            this.lblScoreJogador.Size = new System.Drawing.Size(13, 13);
            this.lblScoreJogador.TabIndex = 18;
            this.lblScoreJogador.Text = "0";
            // 
            // lblScoreCOM
            // 
            this.lblScoreCOM.AutoSize = true;
            this.lblScoreCOM.Location = new System.Drawing.Point(298, 346);
            this.lblScoreCOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreCOM.Name = "lblScoreCOM";
            this.lblScoreCOM.Size = new System.Drawing.Size(13, 13);
            this.lblScoreCOM.TabIndex = 19;
            this.lblScoreCOM.Text = "0";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 376);
            this.Controls.Add(this.lblScoreCOM);
            this.Controls.Add(this.lblScoreJogador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRetorno);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelCOM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.Text = "Adriwil | Jogo de Cartas 21";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultJogador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelJogador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelResultCOM;
        private System.Windows.Forms.Label labelCOM;
        private System.Windows.Forms.Label labelRetorno;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScoreJogador;
        private System.Windows.Forms.Label lblScoreCOM;
    }
}