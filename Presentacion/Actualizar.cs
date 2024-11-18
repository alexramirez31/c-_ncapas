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
    public partial class Actualizar : Form
    {
        public Actualizar()
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
            string[] datos = new string[3];
            datos = usuario.Buscar(textBox1.Text);
            textBox1.Text = datos[0];
            textBox2.Text = datos[1];
            textBox3.Text = datos[2];


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DominioUsuario usuario = new DominioUsuario();
            usuario.Actualizar(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Registro actualizado");
        }
    }
}
