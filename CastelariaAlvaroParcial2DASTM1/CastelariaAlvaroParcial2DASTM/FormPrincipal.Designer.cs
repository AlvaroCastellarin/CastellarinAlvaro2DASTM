namespace Vista
{
    partial class FormPrincipal
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
            btn_gestionClientes = new Button();
            btn_gestionCuentas = new Button();
            btn_movimientos = new Button();
            btn_consultas = new Button();
            label1 = new Label();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_gestionClientes
            // 
            btn_gestionClientes.Location = new Point(12, 30);
            btn_gestionClientes.Name = "btn_gestionClientes";
            btn_gestionClientes.Size = new Size(191, 23);
            btn_gestionClientes.TabIndex = 0;
            btn_gestionClientes.Text = "Gestion Cliente";
            btn_gestionClientes.UseVisualStyleBackColor = true;
            btn_gestionClientes.Click += btn_gestionClientes_Click;
            // 
            // btn_gestionCuentas
            // 
            btn_gestionCuentas.Location = new Point(12, 59);
            btn_gestionCuentas.Name = "btn_gestionCuentas";
            btn_gestionCuentas.Size = new Size(191, 23);
            btn_gestionCuentas.TabIndex = 1;
            btn_gestionCuentas.Text = "Gestion Cuentas Corrientes";
            btn_gestionCuentas.UseVisualStyleBackColor = true;
            btn_gestionCuentas.Click += btn_gestionCuentas_Click;
            // 
            // btn_movimientos
            // 
            btn_movimientos.Location = new Point(12, 88);
            btn_movimientos.Name = "btn_movimientos";
            btn_movimientos.Size = new Size(191, 23);
            btn_movimientos.TabIndex = 2;
            btn_movimientos.Text = "Registro Movimientos";
            btn_movimientos.UseVisualStyleBackColor = true;
            btn_movimientos.Click += btn_movimientos_Click;
            // 
            // btn_consultas
            // 
            btn_consultas.Location = new Point(12, 117);
            btn_consultas.Name = "btn_consultas";
            btn_consultas.Size = new Size(191, 23);
            btn_consultas.TabIndex = 3;
            btn_consultas.Text = "Consultas";
            btn_consultas.UseVisualStyleBackColor = true;
            btn_consultas.Click += btn_consultas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido, seleccione una opcion:";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 145);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(191, 23);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 180);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_consultas);
            Controls.Add(btn_movimientos);
            Controls.Add(btn_gestionCuentas);
            Controls.Add(btn_gestionClientes);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            FormClosed += FormPrincipal_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_gestionClientes;
        private Button btn_gestionCuentas;
        private Button btn_movimientos;
        private Button btn_consultas;
        private Label label1;
        private Button btn_salir;
    }
}