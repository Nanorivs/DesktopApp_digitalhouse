using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;
using Interfaz;
using System.Drawing;



namespace Interfaz.Helpers
{
    public static class Utilidades
    {
        public static void CargarImagen(PictureBox pictureBox,string nombreImagen,bool url = false)
        {
            try
            {
                if (url)   
                   { pictureBox.Load(nombreImagen); }
                else
                {
                    string imagen = ObtenerRutaImagen(nombreImagen);
                    pictureBox.Load(imagen);
                }

            }
            catch 
            {
                string errorImagen = ObtenerRutaImagen("notfound.png");
                pictureBox.Load(errorImagen); 
            }
        }

        public static string ObtenerRutaImagen(string nombreImagen)
        {
            try
            {
                string ruta = Directory.GetCurrentDirectory();
                string rutaRetrocedida = Path.GetFullPath(Path.Combine(ruta, "..",".."));
                string rutaFinal = Path.Combine(rutaRetrocedida,"Resources",nombreImagen);
                return rutaFinal;
            }
            catch (Exception error) 
            {
                    throw error;
            }
        }

        public static void SoloLectura(Control controles, bool soloLectura = true)
        {
            foreach (Control ctrl in controles.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.ReadOnly = soloLectura; 
                }
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.Enabled = !soloLectura; 
                }
                else if (ctrl is NumericUpDown numericUpDown)
                {
                    numericUpDown.Enabled = !soloLectura;
                }
            }
        }

        public static List<string> ProcesarListaComoStrings<T>(List<T> lista)
        {   
            List<string> listaDeStrings = new List<string>();
            foreach (T item in lista)
            { listaDeStrings.Add(item.ToString()); }
            return listaDeStrings;
        }





    }


}
