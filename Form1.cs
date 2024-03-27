using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPesquisaJogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeImagensJogos = Directory.GetFiles(@"C:\Users\erosm\source\repos\ProgramaPesquisaJogo\ImagensJogos\Jogos");

            foreach (string img in nomeImagensJogos) 
            {
                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[8].Split('.');
                
                if(comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox1.ImageLocation = @"C:\Users\erosm\source\repos\ProgramaPesquisaJogo\ImagensJogos\Jogos\" + comboBox2.Text + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jogos = comboBox1.Text;
            comboBox2.Text = string.Empty;

            switch (jogos)
            {
                case "2K":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("2K24");
                    comboBox2.Items.Add("Bioshock");
                    comboBox2.Items.Add("Borderlands");
                    break;

                case "Rockstar":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Bully");
                    comboBox2.Items.Add("GTAV");
                    comboBox2.Items.Add("Read Dead Redemption 2");
                    break;

                case "Naughty Dog":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Crash Bandicoot");
                    comboBox2.Items.Add("The last of Us");
                    comboBox2.Items.Add("Uncharted");
                    break;

                case "Santa Monica":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("God of War 2018");
                    comboBox2.Items.Add("God of War Ragnarok");
                    break;

                case "Team Cherry":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Hollow Knight");
                    comboBox2.Items.Add("Hollow Knight Silksong");
                    break;

                case "Super Giant":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Hades");
                    comboBox2.Items.Add("Hades 2");
                    break;
            }
        }
    }
}
