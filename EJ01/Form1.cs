using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EJ01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlumnosBD bd = new AlumnosDB();
            bool conectado = bd.ProbarConexion();

            if (conectado)
            {
                MessageBox.Show("Conexión OK");
            }
            else
            {
                MessageBox.Show("Error en la conexión");
            }
        }
    }
}
