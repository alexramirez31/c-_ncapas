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
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
            mostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        void mostrarDatos()
        {
            DominioUsuario usuario = new DominioUsuario();
            dataGridView1.DataSource = usuario.mostrar().Tables[0];
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
