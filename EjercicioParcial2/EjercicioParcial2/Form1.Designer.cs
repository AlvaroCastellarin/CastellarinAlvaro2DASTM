namespace EjercicioParcial2
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
            dgv1 = new DataGridView();
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(12, 37);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(745, 164);
            dgv1.TabIndex = 0;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(4, 8);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(81, 23);
            btnAlta.TabIndex = 1;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += button1_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(85, 8);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(81, 23);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(166, 8);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos", "+18", "Cuota al dia" });
            comboBox1.Location = new Point(61, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 210);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Mostrar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 248);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(dgv1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificar;
        private ComboBox comboBox1;
        private Label label1;
    }
}
