using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSocios
{
    public partial class FormAM : Form
    {
        int? Id = null;
        public FormAM(int? id)
        {
            this.Id = id;
            InitializeComponent();
            if (Id != null) RellenarCampos();
        }
        GestionSocios gs = new GestionSocios();
        void RellenarCampos()
        {
            Socio s = gs.ObterSocio((int)Id);
            txtNombre.Text=s.nombre;
            txtApellido.Text=s.apellido;
            txtDni.Text=s.dni;
            dateNac.Value = s.fechaNac;
            nudNroSoc.Value = s.nroSocio;
            if (s.cuotaAlDia == true) chkCuota.Checked = true;
            else chkCuota.Checked = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Id is null)
            {
                bool cuota;
                if (chkCuota.Checked) cuota = true;
                else cuota = false;
                gs.AltaSocio(txtNombre.Text, txtApellido.Text, txtDni.Text, dateNac.Value, (int)nudNroSoc.Value, cuota);
                this.Close();
            }
            else
            {
                bool cuota;
                if (chkCuota.Checked) cuota = true;
                else cuota = false;
                gs.ModificaSocio((int)Id, txtNombre.Text, txtApellido.Text, txtDni.Text, dateNac.Value, (int)nudNroSoc.Value, cuota);
                this.Close();
            }
               
           
        }
    }
}
