using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_3BIMESTRE
{
    public partial class Cadastro_de_produto : Form
    {
        List<Produto> produto = new List<Produto>();
        public Cadastro_de_produto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto1 = new Produto();

            try
            {
                produto1.codigo = textBox2.Text;
                produto1.descricao = textBox5.Text;
                produto1.valor = textBox4.Text;
                produto1.nome = textBox1.Text;
                produto1.quantidade = textBox3.Text;


                produto.Add(produto1);


                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produto;
            }


            catch (FormatException ex)
            {
                MessageBox.Show($"Erro! ");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            produto.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produto;
        }
    }
}
