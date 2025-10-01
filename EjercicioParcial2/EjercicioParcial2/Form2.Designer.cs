namespace EjercicioParcial2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            nudNroSocio = new NumericUpDown();
            checkBox1 = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNroSocio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 45);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 77);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 110);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 146);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Numero de socio:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(60, 74);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(60, 45);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(126, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // nudNroSocio
            // 
            nudNroSocio.Location = new Point(107, 144);
            nudNroSocio.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudNroSocio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNroSocio.Name = "nudNroSocio";
            nudNroSocio.Size = new Size(120, 23);
            nudNroSocio.TabIndex = 9;
            nudNroSocio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Cuota al dia";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(173, 202);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 237);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(nudNroSocio);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDni);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nudNroSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown nudNroSocio;
        private CheckBox checkBox1;
        private Button button1;
    }
}