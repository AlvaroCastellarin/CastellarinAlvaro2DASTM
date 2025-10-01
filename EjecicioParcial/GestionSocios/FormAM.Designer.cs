namespace GestionSocios
{
    partial class FormAM
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            Nom = new Label();
            label1 = new Label();
            label2 = new Label();
            dateNac = new DateTimePicker();
            label3 = new Label();
            nudNroSoc = new NumericUpDown();
            label4 = new Label();
            chkCuota = new CheckBox();
            btnGuardar = new Button();
            txtDni = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudNroSoc).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(72, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(72, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(12, 15);
            Nom.Name = "Nom";
            Nom.Size = new Size(54, 15);
            Nom.TabIndex = 2;
            Nom.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 4;
            label2.Text = "DNI:";
            // 
            // dateNac
            // 
            dateNac.Format = DateTimePickerFormat.Short;
            dateNac.Location = new Point(138, 99);
            dateNac.Name = "dateNac";
            dateNac.Size = new Size(100, 23);
            dateNac.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha de nacimiento:";
            // 
            // nudNroSoc
            // 
            nudNroSoc.Location = new Point(95, 134);
            nudNroSoc.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudNroSoc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNroSoc.Name = "nudNroSoc";
            nudNroSoc.Size = new Size(100, 23);
            nudNroSoc.TabIndex = 8;
            nudNroSoc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 9;
            label4.Text = "Nro de socio:";
            // 
            // chkCuota
            // 
            chkCuota.AutoSize = true;
            chkCuota.Location = new Point(12, 163);
            chkCuota.Name = "chkCuota";
            chkCuota.Size = new Size(89, 19);
            chkCuota.TabIndex = 10;
            chkCuota.Text = "Cuota al dia";
            chkCuota.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 188);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(72, 70);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 12;
            // 
            // FormAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 221);
            Controls.Add(txtDni);
            Controls.Add(btnGuardar);
            Controls.Add(chkCuota);
            Controls.Add(label4);
            Controls.Add(nudNroSoc);
            Controls.Add(label3);
            Controls.Add(dateNac);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nom);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FormAM";
            Text = "FormAM";
            ((System.ComponentModel.ISupportInitialize)nudNroSoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label Nom;
        private Label label1;
        private Label label2;
        private DateTimePicker dateNac;
        private Label label3;
        private NumericUpDown nudNroSoc;
        private Label label4;
        private CheckBox chkCuota;
        private Button btnGuardar;
        private TextBox txtDni;
    }
}