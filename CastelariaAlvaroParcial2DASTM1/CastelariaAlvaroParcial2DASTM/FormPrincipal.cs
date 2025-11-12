using Entidades;
using System.Windows.Forms;
using static Controladora.Controladora;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        private Cliente ClienteActual { get; set; }
        public FormPrincipal(Cliente cliente)
        {
            InitializeComponent();
            ClienteActual = cliente;
        }
        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_gestionClientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente(ClienteActual);
            formCliente.ShowDialog();
        }

        private void btn_gestionCuentas_Click(object sender, EventArgs e)
        {
            FormCuentas formCuentas = new FormCuentas(ClienteActual);
            formCuentas.ShowDialog();
        }

        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            FormMovimientos formMovs = new FormMovimientos(ClienteActual);
            formMovs.ShowDialog();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas(ClienteActual);
            formConsultas.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
