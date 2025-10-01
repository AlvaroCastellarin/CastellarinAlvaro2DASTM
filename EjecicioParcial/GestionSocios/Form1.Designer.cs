namespace GestionSocios
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            btnAlDia = new Button();
            chkMayores = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(745, 170);
            dataGridView1.TabIndex = 0;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(12, 11);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 1;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(93, 12);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(174, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAlDia
            // 
            btnAlDia.Location = new Point(255, 12);
            btnAlDia.Name = "btnAlDia";
            btnAlDia.Size = new Size(84, 23);
            btnAlDia.TabIndex = 4;
            btnAlDia.Text = "Socios al dia";
            btnAlDia.UseVisualStyleBackColor = true;
            btnAlDia.Click += btnAlDia_Click;
            // 
            // chkMayores
            // 
            chkMayores.AutoSize = true;
            chkMayores.Location = new Point(12, 216);
            chkMayores.Name = "chkMayores";
            chkMayores.Size = new Size(203, 19);
            chkMayores.TabIndex = 7;
            chkMayores.Text = "Mostrar solo los mayores de edad";
            chkMayores.UseVisualStyleBackColor = true;
            chkMayores.CheckedChanged += chkMayores_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 288);
            Controls.Add(chkMayores);
            Controls.Add(btnAlDia);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificar;
        private Button btnAlDia;
        private CheckBox chkMayores;
    }
}
