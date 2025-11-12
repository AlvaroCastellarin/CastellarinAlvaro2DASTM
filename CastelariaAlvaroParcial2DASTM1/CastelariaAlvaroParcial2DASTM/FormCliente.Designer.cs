namespace Vista
{
    partial class FormCliente
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
            txt_telefono = new TextBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_dni = new TextBox();
            btn_aceptar = new Button();
            btn_darBaja = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 8);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 4;
            label5.Text = "Ingrese los siguentes datos:";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(72, 121);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(100, 23);
            txt_telefono.TabIndex = 5;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(72, 30);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 6;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(72, 59);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 7;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(72, 88);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(100, 23);
            txt_dni.TabIndex = 8;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(12, 156);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(160, 23);
            btn_aceptar.TabIndex = 9;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_darBaja
            // 
            btn_darBaja.Location = new Point(12, 185);
            btn_darBaja.Name = "btn_darBaja";
            btn_darBaja.Size = new Size(160, 23);
            btn_darBaja.TabIndex = 10;
            btn_darBaja.Text = "Dar de baja";
            btn_darBaja.UseVisualStyleBackColor = true;
            btn_darBaja.Click += btnDarBaja_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 222);
            Controls.Add(btn_darBaja);
            Controls.Add(btn_aceptar);
            Controls.Add(txt_dni);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(txt_telefono);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_telefono;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_dni;
        private Button btn_aceptar;
        private Button btn_darBaja;
    }
}