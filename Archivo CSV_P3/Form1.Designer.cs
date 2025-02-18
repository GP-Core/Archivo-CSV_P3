namespace Archivo_CSV_P3
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
            openFileDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAbrir = new Button();
            dgvMostrar = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Archivo CSV|*.csv";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAbrir, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMostrar, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8613863F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.13861F));
            tableLayoutPanel1.Size = new Size(790, 404);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAbrir
            // 
            btnAbrir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAbrir.Location = new Point(3, 13);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(784, 29);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // dgvMostrar
            // 
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrar.Dock = DockStyle.Fill;
            dgvMostrar.Location = new Point(3, 59);
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.RowHeadersWidth = 51;
            dgvMostrar.Size = new Size(784, 342);
            dgvMostrar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Archivo CSV";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAbrir;
        private DataGridView dgvMostrar;
    }
}
