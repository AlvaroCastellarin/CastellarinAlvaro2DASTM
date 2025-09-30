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
    public partial class formAM : Form
    {
        private int? l;
        public formAM(int? L=null)
        {
            this.l = L;
            InitializeComponent();
            if (l != null) RellenarValores();
        }
        AlumnosDB db = new AlumnosDB();
        void RellenarValores()
        {
            Alumno a = db.ObtenerAlumno((int)l);
            txtNombre.Text = a.nombre;
            numEdad.Value = a.edad;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (l == null)
            {

                if (txtNombre != null) db.AltaAlumno(txtNombre.Text, (int)numEdad.Value);
                else MessageBox.Show("Ingrese un nombre, por favor");
            }
            else
            {
                if (txtNombre.Text != null) db.ModifcaAlumno(txtNombre.Text, (int)numEdad.Value, (int)l);
                else MessageBox.Show("Ingrese un nombre, por favor");
            }
            this.Close();
        }
    }
}
