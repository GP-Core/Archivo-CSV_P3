namespace Archivo_CSV_P3
{
    partial class frmVarios
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaCalculo = new DateTimePicker();
            btnCalcular = new Button();
            btnCurp = new Button();
            label3 = new Label();
            btnEjemplo = new Button();
            txtCurp = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFechaNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpFechaCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCalcular, 1, 4);
            tableLayoutPanel1.Location = new Point(98, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.4516125F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.5483856F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(579, 184);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de calculo";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(3, 26);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(283, 27);
            dtpFechaNacimiento.TabIndex = 2;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // dtpFechaCalculo
            // 
            dtpFechaCalculo.Enabled = false;
            dtpFechaCalculo.Location = new Point(3, 110);
            dtpFechaCalculo.Name = "dtpFechaCalculo";
            dtpFechaCalculo.Size = new Size(283, 27);
            dtpFechaCalculo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(292, 148);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(284, 33);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnCurp
            // 
            btnCurp.Location = new Point(126, 341);
            btnCurp.Name = "btnCurp";
            btnCurp.Size = new Size(144, 29);
            btnCurp.TabIndex = 2;
            btnCurp.Text = "Mostrar Datos";
            btnCurp.UseVisualStyleBackColor = true;
            btnCurp.Click += btnCurp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 285);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 3;
            label3.Text = "CURP";
            // 
            // btnEjemplo
            // 
            btnEjemplo.Location = new Point(290, 308);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(94, 29);
            btnEjemplo.TabIndex = 5;
            btnEjemplo.Text = "Ejemplo";
            btnEjemplo.UseVisualStyleBackColor = true;
            btnEjemplo.Click += btnEjemplo_Click;
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(98, 310);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(186, 27);
            txtCurp.TabIndex = 6;
            // 
            // frmVarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCurp);
            Controls.Add(btnEjemplo);
            Controls.Add(label3);
            Controls.Add(btnCurp);
            Controls.Add(tableLayoutPanel1);
            Name = "frmVarios";
            Text = "frmVarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaCalculo;
        private Button btnCalcular;
        private Button btnCurp;
        private Label label3;
        private Button btnEjemplo;
        private TextBox txtCurp;
    }
}