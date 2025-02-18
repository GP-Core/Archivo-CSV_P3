using System.Text;

namespace Archivo_CSV_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try //Manejo de error 
            {
                openFileDialog.FileName = "";
                DialogResult res = openFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {

                    //Leemos el archivo seleccionado por el usuario
                    string text = File.ReadAllText(openFileDialog.FileName);
                    //Arreglo que termina los renglones
                    string[] reg = text.Split("\n");
                    //Arreglo que ayuda a llevar el control de las columans
                    string[] c = reg[0].Split(",");
                    int co = c.Length;
                    //Asignacion de columnas
                    dgvMostrar.ColumnCount = co;

                    //Asignacion de rengloes
                    dgvMostrar.RowCount = reg.Length;

                    //Para mostar la informacion en el dataGridView
                    for (int i = 0; i < reg.Length - 1; i++)
                    {
                        //se crea un arreglo el cual nos ayuda a manejar individualmente el renglon y su contenido
                        string[] x = reg[i].Split(",");
                        for (int j = 0; j < co; j++)
                        {
                            //Mostramos el renglon 
                            dgvMostrar.Rows[i].Cells[j].Value = x[j];

                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error inesperado al abrir el archivo: " + ex);
            }

        }

       
    }
}
