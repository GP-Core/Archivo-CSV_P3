namespace Archivo_CSV_P3
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            practica4ArchivoCVSToolStripMenuItem = new ToolStripMenuItem();
            practica4NacCurpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { practica4ArchivoCVSToolStripMenuItem, practica4NacCurpToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(81, 24);
            aplicacionesToolStripMenuItem.Text = "Practicas";
            // 
            // practica4ArchivoCVSToolStripMenuItem
            // 
            practica4ArchivoCVSToolStripMenuItem.Name = "practica4ArchivoCVSToolStripMenuItem";
            practica4ArchivoCVSToolStripMenuItem.Size = new Size(238, 26);
            practica4ArchivoCVSToolStripMenuItem.Text = "Practica3_ ArchivoCVS";
            practica4ArchivoCVSToolStripMenuItem.Click += practica4ArchivoCVSToolStripMenuItem_Click;
            // 
            // practica4NacCurpToolStripMenuItem
            // 
            practica4NacCurpToolStripMenuItem.Name = "practica4NacCurpToolStripMenuItem";
            practica4NacCurpToolStripMenuItem.Size = new Size(238, 26);
            practica4NacCurpToolStripMenuItem.Text = "Practica4_Nac_Curp";
            practica4NacCurpToolStripMenuItem.Click += practica4NacCurpToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem practica4ArchivoCVSToolStripMenuItem;
        private ToolStripMenuItem practica4NacCurpToolStripMenuItem;
    }
}