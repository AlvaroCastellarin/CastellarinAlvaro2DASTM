using System.Data;

namespace GestionSocios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // p();
            CargaDGV();
        }
        GestionSocios gs = new GestionSocios();
        /* void p()
         {
             bool pr = gs.prueba();
             if (pr==true) MessageBox.Show("exito");
             else MessageBox.Show("error");
         }*/
        void CargaDGV()
        {
            dataGridView1.DataSource = gs.getSocioList();
        }
        #region helper
        int? GetId()
        {
            try { return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()); }
            catch { return null; }
        }
        #endregion

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                FormAM form = new FormAM(null);
                form.ShowDialog();
                CargaDGV();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null) gs.BajaSocio((int)id);
                CargaDGV();
            }
            catch { MessageBox.Show("Seleccione un socio"); }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    FormAM frm = new FormAM(id);
                    frm.ShowDialog();
                    CargaDGV();
                }
            }
            catch { MessageBox.Show("Elija un socio para modificar"); }
        }

        private void btnAlDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de socios al dia son: " + gs.contadorSociosAlDia());
        }

        private void btnMostrarMayores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gs.SociosMayores();
        }

        private void btnMostrarSocios_Click(object sender, EventArgs e)
        {
            CargaDGV();
        }

        private void chkMayores_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMayores.Checked) CargaDGV();
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = gs.SociosMayores();
            }
        }
    }
}
