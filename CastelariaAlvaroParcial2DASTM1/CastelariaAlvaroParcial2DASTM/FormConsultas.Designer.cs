namespace Vista
{
    partial class FormConsultas
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
            cmb_cuentas = new ComboBox();
            dgv_movimientos = new DataGridView();
            label2 = new Label();
            lbl_ingresos = new Label();
            label4 = new Label();
            lbl_egresos = new Label();
            label6 = new Label();
            lbl_balance = new Label();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_movimientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una cuenta:";
            // 
            // cmb_cuentas
            // 
            cmb_cuentas.FormattingEnabled = true;
            cmb_cuentas.Location = new Point(12, 27);
            cmb_cuentas.Name = "cmb_cuentas";
            cmb_cuentas.Size = new Size(128, 23);
            cmb_cuentas.TabIndex = 1;
            cmb_cuentas.SelectedIndexChanged += cmb_cuentas_SelectedIndexChanged;
            // 
            // dgv_movimientos
            // 
            dgv_movimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_movimientos.Location = new Point(12, 56);
            dgv_movimientos.Name = "dgv_movimientos";
            dgv_movimientos.Size = new Size(582, 193);
            dgv_movimientos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 56);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Total ingresos:";
            // 
            // lbl_ingresos
            // 
            lbl_ingresos.AutoSize = true;
            lbl_ingresos.Location = new Point(689, 56);
            lbl_ingresos.Name = "lbl_ingresos";
            lbl_ingresos.Size = new Size(22, 15);
            lbl_ingresos.TabIndex = 4;
            lbl_ingresos.Text = "---";
            lbl_ingresos.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 91);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 5;
            label4.Text = "Total egresos:";
            // 
            // lbl_egresos
            // 
            lbl_egresos.AutoSize = true;
            lbl_egresos.Location = new Point(689, 91);
            lbl_egresos.Name = "lbl_egresos";
            lbl_egresos.Size = new Size(22, 15);
            lbl_egresos.TabIndex = 6;
            lbl_egresos.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 128);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 7;
            label6.Text = "Balance:";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Location = new Point(689, 128);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(22, 15);
            lbl_balance.TabIndex = 8;
            lbl_balance.Text = "---";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(600, 162);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(131, 23);
            btn_salir.TabIndex = 9;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 270);
            Controls.Add(btn_salir);
            Controls.Add(lbl_balance);
            Controls.Add(label6);
            Controls.Add(lbl_egresos);
            Controls.Add(label4);
            Controls.Add(lbl_ingresos);
            Controls.Add(label2);
            Controls.Add(dgv_movimientos);
            Controls.Add(cmb_cuentas);
            Controls.Add(label1);
            Name = "FormConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu consultas";
            ((System.ComponentModel.ISupportInitialize)dgv_movimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_cuentas;
        private DataGridView dgv_movimientos;
        private Label label2;
        private Label lbl_ingresos;
        private Label label4;
        private Label lbl_egresos;
        private Label label6;
        private Label lbl_balance;
        private Button btn_salir;
    }
}