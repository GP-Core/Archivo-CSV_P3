using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo_CSV_P3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void practica4ArchivoCVSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmArchvioCvs = new Form1();
            frmArchvioCvs.Show();
        }

        private void practica4NacCurpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVarios frmVarios = new frmVarios();  
            frmVarios.Show();
        }
    }
}
