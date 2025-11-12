using Controladora;
using Entidades;
using System;
using System.Windows.Forms;
using Vista;
namespace Controladora
{
    public partial class FormLoginAlta : Form
    {
        public FormLoginAlta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_dni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error de Formato");
                return;
            }
            Cliente clienteLogueado = Controladora.Instancia.ObtenerClientePorDNI(dni);
            if (clienteLogueado != null)
            {
                FormPrincipal principal = new FormPrincipal(clienteLogueado);
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("DNI no registrado. Utilice el botón 'Alta Cliente' para registrarse.", "Error de Login");
            }
        }

        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente(null);
            formCliente.ShowDialog();
            txt_dni.Text = formCliente.DniRegistrado.ToString();
        }
    }
}
