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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertar form = new Insertar();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar form = new Mostrar();
            this.Hide();
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar form = new Eliminar();
            this.Hide();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Actualizar form = new Actualizar();
            this.Hide();
            form.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buscar form = new Buscar();
            this.Hide();
            form.Show();
        }
    }
}
