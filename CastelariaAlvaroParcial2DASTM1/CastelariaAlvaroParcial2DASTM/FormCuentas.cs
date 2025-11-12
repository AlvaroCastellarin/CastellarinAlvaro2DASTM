using Entidades;
using System.Windows.Forms;
using System.Linq;
using static Controladora.Controladora;

namespace Vista
{
    public partial class FormCuentas : Form
    {
        private Cliente ClienteActual { get; set; }

        public FormCuentas(Cliente cliente)
        {
            InitializeComponent();
            ClienteActual = cliente;
            this.Text = $"Gestión de Cuentas para Cliente: {cliente.Nombre}";
            CargarCuentasComboBox();
        }

        private void CargarCuentasComboBox()
        {
            ClienteActual = Instancia.ObtenerClientePorDNI(ClienteActual.DNI);
            cmb_cuentas.DataSource = null;
            if (ClienteActual.Cuentas != null && ClienteActual.Cuentas.Any())
            {
                cmb_cuentas.DataSource = ClienteActual.Cuentas;
                cmb_cuentas.DisplayMember = "nro_cta";
                cmb_cuentas.ValueMember = "id_cta";
                btn_consultarSaldo.Enabled = true;
            }
            else
            {
                cmb_cuentas.Items.Clear();
                cmb_cuentas.Text = "No hay cuentas disponibles";
                btn_consultarSaldo.Enabled = false;
            }
        }
        private void btn_consultarSaldo_Click(object sender, EventArgs e)
        {
            if (cmb_cuentas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una cuenta para consultar el saldo.", "Error de Selección");
                return;
            }

            if (!int.TryParse(cmb_cuentas.SelectedValue.ToString(), out int idCuentaSeleccionada))
            {
                MessageBox.Show("Error al obtener el ID de cuenta.", "Error Interno");
                return;
            }
            decimal saldo = Instancia.CalcularSaldo(idCuentaSeleccionada);
            CuentaCorriente cuentaSeleccionada = (CuentaCorriente)cmb_cuentas.SelectedItem;
            int nroCuenta = cuentaSeleccionada.nro_cta;
            string estadoSaldo = saldo >= 0 ? "Favorable" : "Deuda Pendiente";
            MessageBox.Show(
                $"Número de Cuenta: {nroCuenta}\n" +
                $"Saldo Actual: {saldo.ToString("C")}\n" +
                $"Estado: {estadoSaldo}",
                "Consulta de Saldo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void FormCuentas_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevaCuenta_Click(object sender, EventArgs e)
        {
            string resultado = Instancia.CrearCuentaCorriente(ClienteActual.id_cli);
            MessageBox.Show(resultado, "Creación de Cuenta");

            if (resultado.StartsWith("Cuenta Corriente creada")) CargarCuentasComboBox();
        }
    }
}
