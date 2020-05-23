using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();
        private void btn_dados_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_nome.Text;
                obj.Idade = int.Parse(txt_idade.Text);
                obj.Peso = double.Parse(txt_peso.Text);
                obj.Altura = double.Parse(txt_altura.Text);
                MessageBox.Show("Dados armazenados!");

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_imc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimirDados() +
                "\n\nIMC: " + obj.CalculaIMC().ToString("F"));
            txt_imctotal.Text = obj.CalculaIMC().ToString("F");
        }
    }
}