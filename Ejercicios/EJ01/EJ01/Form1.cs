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
            //prueba();
            CargaDGV();
        }
        AlumnosDB db = new AlumnosDB();
        /* void prueba()
         {
             bool p = db.prueba();
             if (p == true) MessageBox.Show("Conexion exitosa");
             else MessageBox.Show("error");
         }*/

        void CargaDGV()
        {
            dgvAlumnos.DataSource = db.ListaAlumnos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            formAM form = new formAM();
            form.ShowDialog();
            CargaDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? l = (int)ObtenerLegajo();
            try
            {
                if (l != null) 
                {
                    db.BajaAlumno((int)l);
                    CargaDGV(); 
                }
            }
            catch (Exception ex) {throw new Exception("Error: " +  ex.Message);}
        }
    #region Helper 
        int? ObtenerLegajo()
        {
            int l = int.Parse(dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].Cells[0].Value.ToString());
            return l;
        }
        #endregion
    }
}
