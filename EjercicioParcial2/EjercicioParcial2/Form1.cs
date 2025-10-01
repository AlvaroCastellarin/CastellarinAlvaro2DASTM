namespace EjercicioParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //prueba();
            CargaDGV();
        }
        GestroSocios gs = new GestroSocios();
        void CargaDGV()
        {
            try
            {
                dgv1.DataSource = gs.ListaSocios();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        int? ObtenerId()
        {
            try
            {
                return int.Parse(dgv1.Rows[dgv1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); throw; }
        }
        void prueba()
        {
            try
            {
                if (gs.prueba()) MessageBox.Show("bien");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            CargaDGV();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = ObtenerId();
                if (id != null) gs.BajaSocio((int)id);
                else MessageBox.Show("Seleccione un socio que quiera eliminar");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message);  }
            CargaDGV();
        }
    }
}
