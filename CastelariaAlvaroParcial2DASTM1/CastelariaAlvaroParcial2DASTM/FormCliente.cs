using Entidades;
using static Controladora.Controladora;
using System.Windows.Forms;
using System;

namespace Vista
{
    public partial class FormCliente : Form
    {
        private Cliente ClienteAEditar { get; set; }
        public int DniRegistrado { get; private set; }

        public FormCliente(Cliente cliente)
        {
            InitializeComponent();
            ClienteAEditar = cliente;

            if (cliente != null)
            {
                this.Text = "Modificar / Dar de Baja Cliente";
                PrecargarDatos(cliente);
                btn_darBaja.Visible = true;
            }
            else
            {
                // Modo ALTA
                this.Text = "Alta de Nuevo Cliente";
                btn_darBaja.Visible = false;
            }
        }

        private void PrecargarDatos(Cliente cliente)
        {
            txt_nombre.Text = cliente.Nombre;
            txt_apellido.Text = cliente.Apellido;
            txt_dni.Text = cliente.DNI.ToString();
            txt_telefono.Text = cliente.Telefono.ToString();
            txt_dni.Enabled = false;
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_dni.Text, out int dni) || !int.TryParse(txt_telefono.Text, out int telefono))
            {
                MessageBox.Show("DNI y Teléfono deben ser números enteros válidos.", "Error de Formato");
                return;
            }
            if (ClienteAEditar == null)
            {
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = txt_nombre.Text,
                    Apellido = txt_apellido.Text,
                    DNI = dni,
                    Telefono = telefono
                };

                string resultado = Instancia.AgregarCliente(nuevoCliente);

                if (resultado.StartsWith("Cliente registrado"))
                {
                    DniRegistrado = dni;
                    MessageBox.Show(resultado, "Alta Exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resultado, "Error de Alta");
                }
            }
            else
            {
                ClienteAEditar.Nombre = txt_nombre.Text;
                ClienteAEditar.Apellido = txt_apellido.Text;
                ClienteAEditar.Telefono = telefono;

                string resultado = Instancia.ModificarCliente(ClienteAEditar);

                if (resultado.StartsWith("Cliente modificado"))
                {
                    MessageBox.Show(resultado, "Modificación Exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resultado, "Error de Modificación");
                }
            }
        }
        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            // Solo permitimos la baja si estamos en modo Modificación
            if (ClienteAEditar == null) return;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de dar de baja su cuenta y ELIMINAR TODAS SUS CUENTAS y MOVIMIENTOS?",
                "Confirmar Eliminación Total",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                string resultado = Instancia.EliminarCliente(ClienteAEditar);

                MessageBox.Show(resultado, "Baja de Usuario");

                if (resultado.StartsWith("Cliente eliminado"))
                {
                    this.Close();
                    Form principal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
                    if (principal != null)
                    {
                        principal.Close();
                    }
                }
            }
        }
    }
}