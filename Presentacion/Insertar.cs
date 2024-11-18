using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DominioUsuario usuario = new DominioUsuario();
            usuario.Insertar(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Registro Insertado con exito");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
