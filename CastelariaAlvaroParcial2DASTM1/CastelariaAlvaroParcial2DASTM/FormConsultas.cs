using Entidades;
using System.Windows.Forms;
using System.Linq;
using static Controladora.Controladora;

namespace Vista
{
    public partial class FormConsultas : Form
    {
        private Cliente ClienteActual { get; set; }

        public FormConsultas(Cliente cliente)
        {
            InitializeComponent();
            ClienteActual = cliente;
            this.Text = $"Consultas e Informes: {cliente.Nombre}";
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
                cmb_cuentas.SelectedIndex = 0;
            }
            else
            {
                cmb_cuentas.Text = "No hay cuentas para consultar.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_cuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cuentas.SelectedValue != null && cmb_cuentas.SelectedValue is int)
            {
                int idCuentaSeleccionada = (int)cmb_cuentas.SelectedValue;
                RellenarHistorial(idCuentaSeleccionada);
                MostrarResumen(idCuentaSeleccionada);
            }
        }
        private void RellenarHistorial(int idCuenta)
        {
            var historial = Instancia.VerHistorial(idCuenta);
            var datosParaDGV = historial.Select(m => new
            {
                NroCuenta = m.CuentaCorriente != null ? m.CuentaCorriente.nro_cta : m.id_cta,

                Fecha = m.Fecha.ToShortDateString(),
                Tipo = m.Tipo.ToString(),
                Descripcion = m.Descripcion,
                Monto = m.Monto.ToString("C")
            }).ToList();

            dgv_movimientos.DataSource = datosParaDGV;
        }

        private void MostrarResumen(int idCuenta)
        {
            var resumen = Instancia.ObtenerResumen(idCuenta);
            lbl_ingresos.Text = resumen.totalCreditos.ToString("C");
            lbl_egresos.Text = resumen.totalDebitos.ToString("C");
            lbl_balance.Text = resumen.saldo.ToString("C");

            lbl_balance.ForeColor = resumen.saldo >= 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }
    }
}
