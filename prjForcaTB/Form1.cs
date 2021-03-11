using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjForcaTB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Forca jogo;

        string[] lista;
        string[] dicas;

        Label[] letras;
        int palpites = 0;

        int tempo = 120;
        
        SoundPlayer musica;

        private void carregarMusica(){
            string caminho = Environment.CurrentDirectory + "\\musicaAdm.wav";
            musica = new SoundPlayer();
            musica.SoundLocation = caminho;
            musica.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            carregarLista();
            jogo = new Forca(lista, 0);
            jogo.sortear();
            desenharPalavra(jogo.devolvePalavra());
            //exibe dica
            gbPalavra.Text = "DICA: " + dicas[jogo.Pos];
            timer1.Enabled = true;
            carregarMusica();
        }

        private void carregarLista()
        {
            string caminho = Environment.CurrentDirectory + "\\lista.txt";
            if (File.Exists(caminho))
            {
                StreamReader arquivo = new StreamReader(caminho);
                int qtd = File.ReadAllLines(caminho).Count();
                lista = new string[qtd];
                dicas = new string[qtd];
                for (int i = 0; i < qtd; i++)
                {
                    string[] campos = arquivo.ReadLine().Split(',');
                    lista[i] = campos[0];
                    dicas[i] = campos[1];

                }
                arquivo.Close();
            }
            else
            {
                MessageBox.Show("Lista não encontrada!!!");
                Environment.Exit(0);
            }
        }

        private void desenharPalavra(string p)
        {
            letras = new Label[p.Length];
            int pv = 35;
            int ph = 10;
            for (int i = 0; i < letras.Count(); i++)
            {
                letras[i] = new Label();
                letras[i].Text = "?";//"?"p.Substring(i, 1);
                letras[i].Width = 30;
                letras[i].Height = 30;
                letras[i].TextAlign = ContentAlignment.MiddleCenter;
                letras[i].ForeColor = Color.Black;
                letras[i].BackColor = Color.White;
                letras[i].BorderStyle = BorderStyle.FixedSingle;
                letras[i].AutoSize = false;
                if (1 % 10 == 0)
                {
                    pv += 35;
                    ph = 10;
                }
                letras[i].Top = pv;
                letras[i].Left = ph;
                ph += 35;
                gbPalavra.Controls.Add(letras[i]);
                letras[i].Show();
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            desenharLetra(txtLetra.Text);
            txtLetra.Clear();
            txtLetra.Focus();

        }

        private void desenharLetra(string letra)
        {
            bool achou = false;

            if (lblLetraDigitada.Text.Contains(letra))
            {
                MessageBox.Show("Letra ja foi digitada");
                return;
            }
            lblLetraDigitada.Text += letra;
            string p = jogo.devolvePalavra();
            for (int i = 0; i < p.Length; i++)
            {
                if (p.Substring(i,1).Equals(letra))
                {
                    letras[i].Text = letra;
                    achou = true;
                }
            }
            if (achou == false)
            {
                palpites++;
                desenharEnforcado();
            }
            if(palpites == 6)
            {
                timer1.Enabled = false;
                MessageBox.Show("Você perdeu!, a palavra era " + p);
                novoJogo();
            }
            checarVitoria();
        }

        private void checarVitoria()
        {
            string tmp = "";
            foreach (Label item in letras)
            {
                tmp += item.Text;            }
            string p = jogo.devolvePalavra();
            if (p.Equals(tmp))
            {
                timer1.Enabled = false;
                MessageBox.Show("Você venceu");
                novoJogo();
            }

        }

        private void novoJogo()
        {
            palpites = 0;
            pbEnforcado.Image = null;
            lblLetraDigitada.Text = "";
            jogo.sortear();
            gbPalavra.Controls.Clear();
            desenharPalavra(jogo.devolvePalavra());
            //exibe dica
            gbPalavra.Text = "DICA: " + dicas[jogo.Pos];
            tempo = 120;
            timer1.Enabled = true;
        }

        private void desenharEnforcado()
        {
            string caminho = Environment.CurrentDirectory + "\\imagem\\forca" + palpites.ToString()+".png";
            if (File.Exists(caminho))
            {
                pbEnforcado.Image = Image.FromFile(caminho);
            }
           
        }

        private void txtLetra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnJogar_Click(sender, e);
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja Jogar Novamente?",
                 "Alerta", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                novoJogo();
            }
        }

        private void btnSairJogo_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja sair?",
                 "Alerta", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCronometro.Text = tempo.ToString() + " seg";
            tempo--;
            if(tempo <= 99)
            {
                lblCronometro.ForeColor = Color.Red;
                Console.Beep();
            }

            if (tempo == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tempo esgotado. A palavra era " 
                    + jogo.devolvePalavra());
                novoJogo();
            }
        }
    }
}