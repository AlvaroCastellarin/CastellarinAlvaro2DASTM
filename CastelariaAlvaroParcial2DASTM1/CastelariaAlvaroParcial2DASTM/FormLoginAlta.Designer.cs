namespace Controladora
{
    partial class FormLoginAlta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_dni = new TextBox();
            btn_acceder = new Button();
            btn_altaCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese DNI:";
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(89, 6);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(100, 23);
            txt_dni.TabIndex = 1;
            // 
            // btn_acceder
            // 
            btn_acceder.Location = new Point(12, 35);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(177, 23);
            btn_acceder.TabIndex = 2;
            btn_acceder.Text = "Acceder";
            btn_acceder.UseVisualStyleBackColor = true;
            btn_acceder.Click += button1_Click;
            // 
            // btn_altaCliente
            // 
            btn_altaCliente.Location = new Point(12, 64);
            btn_altaCliente.Name = "btn_altaCliente";
            btn_altaCliente.Size = new Size(177, 23);
            btn_altaCliente.TabIndex = 3;
            btn_altaCliente.Text = "Alta Cliente";
            btn_altaCliente.UseVisualStyleBackColor = true;
            btn_altaCliente.Click += btn_altaCliente_Click;
            // 
            // FormLoginAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 106);
            Controls.Add(btn_altaCliente);
            Controls.Add(btn_acceder);
            Controls.Add(txt_dni);
            Controls.Add(label1);
            Name = "FormLoginAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_dni;
        private Button btn_acceder;
        private Button btn_altaCliente;
    }
}
