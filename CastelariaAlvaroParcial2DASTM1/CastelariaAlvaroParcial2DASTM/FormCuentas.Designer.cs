namespace Vista
{
    partial class FormCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_nuevaCuenta = new Button();
            btn_consultarSaldo = new Button();
            cmb_cuentas = new ComboBox();
            label1 = new Label();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_nuevaCuenta
            // 
            btn_nuevaCuenta.Location = new Point(12, 82);
            btn_nuevaCuenta.Name = "btn_nuevaCuenta";
            btn_nuevaCuenta.Size = new Size(178, 23);
            btn_nuevaCuenta.TabIndex = 0;
            btn_nuevaCuenta.Text = "Nueva Cuenta";
            btn_nuevaCuenta.UseVisualStyleBackColor = true;
            btn_nuevaCuenta.Click += btn_nuevaCuenta_Click;
            // 
            // btn_consultarSaldo
            // 
            btn_consultarSaldo.Location = new Point(12, 54);
            btn_consultarSaldo.Name = "btn_consultarSaldo";
            btn_consultarSaldo.Size = new Size(178, 23);
            btn_consultarSaldo.TabIndex = 1;
            btn_consultarSaldo.Text = "Consultar Saldo";
            btn_consultarSaldo.UseVisualStyleBackColor = true;
            btn_consultarSaldo.Click += btn_consultarSaldo_Click;
            // 
            // cmb_cuentas
            // 
            cmb_cuentas.FormattingEnabled = true;
            cmb_cuentas.Location = new Point(12, 25);
            cmb_cuentas.Name = "cmb_cuentas";
            cmb_cuentas.Size = new Size(178, 23);
            cmb_cuentas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione una cuenta corriente:";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 111);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(175, 23);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // FormCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 144);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(cmb_cuentas);
            Controls.Add(btn_consultarSaldo);
            Controls.Add(btn_nuevaCuenta);
            Name = "FormCuentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Cuenta Corriente";
            Load += FormCuentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_nuevaCuenta;
        private Button btn_consultarSaldo;
        private ComboBox cmb_cuentas;
        private Label label1;
        private Button btn_salir;
    }
}