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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Ccliente_Click(object sender, EventArgs e)
        {
            Cadastro_de_cliente c = new Cadastro_de_cliente();
            c.ShowDialog();
        }

        private void bt_Cservicos_Click(object sender, EventArgs e)
        {
            Cadastro_de_servico s = new Cadastro_de_servico();
            s.ShowDialog();
        }

        private void bt_Cproduto_Click(object sender, EventArgs e)
        {
            Cadastro_de_produto p = new Cadastro_de_produto();
            p.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
