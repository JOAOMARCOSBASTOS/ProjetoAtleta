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

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                obj.Nome = txtNome.Text;
                obj.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
                obj.Altura = double.Parse(txtAltura.Text);
                obj.Peso = double.Parse(txtPeso.Text);
                MessageBox.Show("Dados armazenados.");
                txtAltura.Text = "";
                txtDataNascimento.Text = "";
                txtPeso.Text = "";
                txtNome.Text = "";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Erro de Divisão por Zero.\n" + ex.Message);
            }
            catch (FormatException ex)      //objeto ex armazena as informações geradas pela exceção
            {
                MessageBox.Show("Erro de execução.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }



        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIMC_Click(object sender, EventArgs e)
        {

        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)  
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimeDados() + "\n\nIdade: " + obj.CalcularIdade().ToString("00") +
    "\n\nIMC: " + obj.CalcularIMC().ToString("00"));
            txtIdade.Text = obj.CalcularIdade().ToString();
            txtIMC.Text = obj.CalcularIMC().ToString();
        }
    }
}