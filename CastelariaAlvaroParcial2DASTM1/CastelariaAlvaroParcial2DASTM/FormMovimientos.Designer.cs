namespace Vista
{
    partial class FormMovimientos
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
            cmb_cuentas = new ComboBox();
            cmb_tipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_descripcion = new TextBox();
            txt_monto = new TextBox();
            btn_aceptar = new Button();
            SuspendLayout();
            // 
            // cmb_cuentas
            // 
            cmb_cuentas.FormattingEnabled = true;
            cmb_cuentas.Location = new Point(139, 12);
            cmb_cuentas.Name = "cmb_cuentas";
            cmb_cuentas.Size = new Size(121, 23);
            cmb_cuentas.TabIndex = 0;
            // 
            // cmb_tipo
            // 
            cmb_tipo.FormattingEnabled = true;
            cmb_tipo.Location = new Point(49, 79);
            cmb_tipo.Name = "cmb_tipo";
            cmb_tipo.Size = new Size(121, 23);
            cmb_tipo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione una cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 82);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 113);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Monto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 113);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 6;
            label5.Text = "$";
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(83, 48);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(230, 23);
            txt_descripcion.TabIndex = 7;
            // 
            // txt_monto
            // 
            txt_monto.Location = new Point(49, 108);
            txt_monto.Name = "txt_monto";
            txt_monto.Size = new Size(121, 23);
            txt_monto.TabIndex = 8;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(2, 137);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(311, 23);
            btn_aceptar.TabIndex = 9;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // FormMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 170);
            Controls.Add(btn_aceptar);
            Controls.Add(txt_monto);
            Controls.Add(txt_descripcion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_tipo);
            Controls.Add(cmb_cuentas);
            Name = "FormMovimientos";
            Text = "FormMovimientos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_cuentas;
        private ComboBox cmb_tipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_descripcion;
        private TextBox txt_monto;
        private Button btn_aceptar;
    }
}