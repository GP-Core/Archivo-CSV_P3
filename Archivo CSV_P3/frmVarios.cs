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
    public partial class frmVarios : Form
    {
        public frmVarios()
        {
            InitializeComponent();
        }
        //Funcion para encontrar el estado
        static string nombreEstado(string clave)
        {
            bool encontrado = false;
            int i = 0;
            //matriz bidemensional para los estados ejemplo:¨ estados(0,1)  muestra aguascalientes y estados (0,0) muestra as
            string[,] estados = {{"AS", "Aguascalientes"},{"BC", "Baja California"},{"BS", "Baja California Sur"},{"CC", "Campeche"},
                            {"CS", "Chiapas"},{"CH", "Chihuahua"},{"CL", "Coahuila"},{"CM", "Colima"},{"DG", "Durango"},
                            {"GT", "Guanajuato"},{"GR", "Guerrero"},{"HG", "Hidalgo"},{"JC", "Jalisco"},{"DF", "Ciudad de México"},{"MN", "Michoacán"},
                            {"MS", "Morelos"},{"NT", "Nayarit"},{"NL", "Nuevo León"},{"OC", "Oaxaca"},{"PL", "Puebla"},{"QT", "Querétaro"},
                            {"QR", "Quintana Roo"},{"SL", "San Luis Potosí"},{"SI", "Sinaloa"},{"SR", "Sonora"},{"TB", "Tabasco"},
                            {"TM", "Tamaulipas"},{"TL", "Tlaxcala"},{"VZ", "Veracruz"}, {"YN", "Yucatán"}, {"ZS", "Zacatecas"}};
            while (encontrado != true )
            {
                if (i >= (estados.Length /2)-1)
                {
                    //creamos una excepcion para si no se introdujo 
                    throw new Exception("Estado no encotrado");
                }
                if (clave == estados[i, 0])
                {
                    encontrado = true;
                }
                else
                    i++;
            }
            return estados[i,1];

        }
        //funcion para validar numeros en el curp y tamaño
        static void  validarCurp(string curp)
        {

            if (curp.Length < 18 || curp.Length > 18)
            {
               //excepcion para el tamaño
                throw new Exception("El tamaño de la curp no es correcto");
            }
            string fechas = curp.Substring(4, 6);
            try
            {
                 int fecha = int.Parse(fechas);
            }
            catch (Exception ex)
            {

                //excepcion para la fecha
                throw new Exception("Fecha no introducida correctamente");
            }
        }
        //funcion para calcular la edad
        static string edadCurp(string fecha) 
        {
            string edad ="";
            int aNac = int.Parse(fecha.Substring(0, 2));
            //operador ternario
            int edads = aNac >=  0 &&aNac <=24 ? aNac + 2000 : aNac + 1900;
            int meses = DateTime.Now.Month - int.Parse(fecha.Substring(2, 2));
            int dias = DateTime.Now.Day-int.Parse(fecha.Substring(4,2));
            edads = DateTime.Now.Year - edads;

            if (meses < 0)
            {
                edads--;
                meses += 12;
            }
            if(dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month-1);
            }
            edad = edads + " años, " + meses + " meses, " + dias + (dias<2 ?" dia " : " dias");
            return edad;
        }
        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaCalculo.Enabled = true;
            btnCalcular.Enabled = true;

            dtpFechaCalculo.MinDate = dtpFechaNacimiento.Value;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime fechaNac = dtpFechaNacimiento.Value;
            DateTime fechaCal = dtpFechaCalculo.Value;

            int edad = fechaCal.Year - fechaNac.Year;
            int meses = fechaCal.Month - fechaNac.Month;
            int dias = fechaCal.Day - fechaNac.Day;


            if (fechaCal.Month < fechaNac.Month)
            {
                edad--;
                meses += 12;
            }
            if (fechaCal.Day < fechaNac.Day)
            {
                meses--;
                dias += DateTime.DaysInMonth(fechaCal.Year, fechaCal.Month - 1);
            }
            MessageBox.Show("Años: " + edad + " Meses: " + meses + " Dias: " + dias, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            txtCurp.Text = "GOMJ980512HDFRNL03";
        }

        private void btnCurp_Click(object sender, EventArgs e)
        {
            try
            {
                txtCurp.Text = txtCurp.Text.ToUpper();
                validarCurp(txtCurp.Text);
                if (txtCurp.Text.Substring(10, 1) != "M" && txtCurp.Text.Substring(10, 1) != "H")
                { 
                    //tipo de excepcion creada "Localmente para el sexo"
                    MessageBox.Show("Sexo no especificado correctamente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //operador ternario
                string sexo = txtCurp.Text.Substring(10, 1) =="M" ? "Mujer" : "Hombre";
                string edad = edadCurp(txtCurp.Text.Substring(4, 6));
                string estado = nombreEstado(txtCurp.Text.Substring(11, 2));
                MessageBox.Show("Edad: " + edad + "\n Estado: " + estado + "\n Sexo: " + sexo);
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex);
            }
            //MessageBox.Show(edadCurp(txtCurp.Text.Substring(4,6)));
            //string estado = txtCurp.Text.Substring(11, 2);
            //MessageBox.Show(nombreEstado(txtCurp.Text.Substring(11, 2)));
           

        }
    }
}
