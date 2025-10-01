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
        void prueba()
        {
            try
            {
                if (gs.prueba()) MessageBox.Show("bien");
            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            CargaDGV();
        }
    }
}
