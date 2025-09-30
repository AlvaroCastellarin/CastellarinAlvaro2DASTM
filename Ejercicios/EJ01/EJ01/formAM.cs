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
        public formAM()
        {
            InitializeComponent();
        }
        AlumnosDB db = new AlumnosDB();

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre != null) db.AltaAlumno(txtNombre.Text, (int)numEdad.Value);
            else MessageBox.Show("Ingrese un nombre, por favor");
            this.Close();
        }
    }
}
