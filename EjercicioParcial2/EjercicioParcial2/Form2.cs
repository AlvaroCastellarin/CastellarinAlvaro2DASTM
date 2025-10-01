using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioParcial2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        GestroSocios gs = new GestroSocios();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido != null && txtNombre != null && txtDni != null && txtDni.Text.Length >= 7)
                {
                    if (!gs.ListaSocios().Any(x => x.NroSocio != (int)nudNroSocio.Value))
                    {
                        bool alDia = false;
                        if (checkBox1.Checked == true) alDia = true;
                        gs.AltaSocio(txtNombre.Text, txtApellido.Text, txtDni.Text, dateTimePicker1.Value, (int)nudNroSocio.Value, alDia);
                        this.Close();
                    }
                    else MessageBox.Show("Ese numero de socio esta ingresado");
                }
                else MessageBox.Show("Rellenar campos vacios");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
