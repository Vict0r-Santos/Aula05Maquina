using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05MaquinadeVendas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void lblsaldo_Click(object sender, EventArgs e)
		{

		}

		private void btnagua_Click(object sender, EventArgs e)
		{
			double valor;
			double agua = 3;
			string nome = lblnomeprod1.Text;

			
			valor = double.Parse(lblsaldo.Text.Replace("R$", ""));

			if (valor >= 3)
			{
				double sub = valor - agua;
				lblsaldo.Text = $"{sub}";
				MessageBox.Show($"Você comprou {nome}");
				txtsaldo.Clear();
			}
			else
			{
				MessageBox.Show("Saldo Insuficiente");
			}
		}

		private void button5_Click(object sender, EventArgs e)

		{
			double valor;
			double saldo;

			valor = double.Parse(txtsaldo.Text);
			saldo = double.Parse(lblsaldo.Text.Replace("R$", ""));
			double soma = saldo + valor;

			lblsaldo.Text = $"R$ {soma}";
			txtsaldo.Clear();
		}

		private void btnsalgadinho_Click(object sender, EventArgs e)
		{
			double valor;
			double salgadinho = 5;
			string nome = nomeprod2.Text;


			valor = double.Parse(lblsaldo.Text.Replace("R$", ""));

			if (valor >= 5)
			{
				double sub = valor - salgadinho;
				lblsaldo.Text = $"{sub}";
				MessageBox.Show($"Você comprou {nome}");
				txtsaldo.Clear();
			}
			else
			{
				MessageBox.Show("Saldo Insuficiente");
			}
		}

		private void btnchocolate_Click(object sender, EventArgs e)
		{
			double valor;
			double choc = 4;
			string nome = nomeprod3.Text;


			valor = double.Parse(lblsaldo.Text.Replace("R$", ""));

			if (valor >= 4)
			{
				double sub = valor - choc;
				lblsaldo.Text = $"{sub}";
				MessageBox.Show($"Você comprou {nome}");
				txtsaldo.Clear();
			}
			else
			{
				MessageBox.Show("Saldo Insuficiente");
			}
		}

		private void btnmonster_Click(object sender, EventArgs e)
		{
			double valor;
			double monster = 10;
			string nome = nomeprod4.Text;


			valor = double.Parse(lblsaldo.Text.Replace("R$", ""));

			if (valor >= 10)
			{
				double sub = valor - monster;
				lblsaldo.Text = $"{sub}";
				MessageBox.Show($"Você comprou {nome}");
				txtsaldo.Clear();
			}
			else
			{
				MessageBox.Show("Saldo Insuficiente");
			}
		}
	}
}
