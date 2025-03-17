using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Helpers
{
    public class Validaciones
    {
        public static bool ValidarDecision(string encabezado) 
        {           
            if (encabezado == null)
                return false;

            DialogResult respuesta = MessageBox.Show("¿Está seguro?", encabezado, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public static void SoloNumeros(ToolStripTextBox toolStripText)
        {
            toolStripText.KeyPress += (sender, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
                {
                    e.Handled = true; 
                }
            };
        }

    }

}
