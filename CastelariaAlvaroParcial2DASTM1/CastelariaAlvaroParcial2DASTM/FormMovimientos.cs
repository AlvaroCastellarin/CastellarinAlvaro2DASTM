using Entidades;
using System.Windows.Forms;
using System.Linq;
using static Controladora.Controladora;

namespace Vista
{
    public partial class FormMovimientos : Form
    {
        private Cliente ClienteActual { get; set; }

        public FormMovimientos(Cliente cliente)
        {
            InitializeComponent();
            ClienteActual = cliente;
            this.Text = $"Registro de Movimientos para: {cliente.Nombre}";
            CargarCuentasComboBox();
            CargarTiposMovimientoComboBox();
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
                btn_aceptar.Enabled = true;
            }
            else
            {
                cmb_cuentas.Items.Clear();
                cmb_cuentas.Text = "No hay cuentas (Cree una primero)";
                btn_aceptar.Enabled = false;
            }
        }

        private void CargarTiposMovimientoComboBox()
        {
            cmb_tipo.DataSource = Enum.GetValues(typeof(TipoMovimiento));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            if (cmb_cuentas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una cuenta corriente.", "Error de Validación");
                return;
            }
            if (cmb_tipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar si es Débito o Crédito.", "Error de Validación");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción para el movimiento.", "Error de Validación");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_monto.Text))
            {
                MessageBox.Show("Debe ingresar un monto.", "Error de Validación");
                return;
            }
            if (!decimal.TryParse(txt_monto.Text, out decimal monto))
            {
                MessageBox.Show("El monto debe ser un valor numérico válido (ej: 100.00).", "Error de Formato");
                return;
            }

            int idCuentaSeleccionada = (int)cmb_cuentas.SelectedValue;

            Movimiento nuevoMovimiento = new Movimiento
            {
                id_cta = idCuentaSeleccionada,
                Descripcion = txt_descripcion.Text,
                Monto = monto,
                Fecha = DateTime.Now,

                Tipo = (TipoMovimiento)cmb_tipo.SelectedItem
            };
 
            string resultado = Instancia.AgregarMovimiento(nuevoMovimiento);
            MessageBox.Show(resultado, "Registro de Movimiento");

            if (resultado.StartsWith("Movimiento de") && !resultado.Contains("Error:"))
            {
                txt_descripcion.Clear();
                txt_monto.Clear();
            }
        }
    }
}
