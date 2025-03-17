using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;


namespace Interfaz
{
    public static class Apariencia
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private static Color colorBarra = ConvertirRGB("11; 7; 17");
        private static Color colorForm = ConvertirRGB("22; 20; 28");
        private static Color colorFondoBotones = ConvertirRGB("87; 79; 115");
        private static Color colorLetrasTextos = ConvertirRGB("0;0;0");
        private static Color colorLabels = ConvertirRGB("216; 209; 237");
        private static Color colorFondoTextos = ConvertirRGB("225, 217, 250");

        private static Font fuenteLabels = new Font("Trebuchet MS", 16, FontStyle.Regular); // Trebuchet MS; 15,75pt

        public static void PersonalizarForm(Form form)
        {
            try
            {
                form.FormBorderStyle = FormBorderStyle.None;
                ColorearComponentes(form);
                AgregarBordesPaneles(form, colorBarra);
                AgregarBotonesVentana(form, colorBarra);
                AgregarIconoTitulo(form, colorBarra);
                form.BackColor = colorForm;

            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }

        private static void ColorearComponentes(Control controles)
        {
            foreach (Control ctrl in controles.Controls)
            {

                if (ctrl is DataGridView dataGridView)
                {
                    dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dataGridView.EnableHeadersVisualStyles = false; // Para aplicar los cambios en los encabezados

                    dataGridView.BackgroundColor = colorForm;

                    dataGridView.DefaultCellStyle.BackColor = colorFondoTextos; 
                    dataGridView.DefaultCellStyle.ForeColor = colorLetrasTextos; 

                    dataGridView.DefaultCellStyle.SelectionBackColor = colorFondoBotones;  
                    dataGridView.DefaultCellStyle.SelectionForeColor = colorFondoTextos;    

                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = colorBarra;
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                }
                else if (ctrl is Button)
                {
                    ctrl.BackColor = colorFondoBotones;
                    ctrl.ForeColor = colorLetrasTextos;
                    ctrl.Cursor = Cursors.Hand;   
                }
                else if (ctrl is Label)
                {
                    ctrl.BackColor = colorForm;
                    ctrl.ForeColor = colorLabels;
                    ctrl.Font = fuenteLabels;
                }
                else if (ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.BackColor = colorFondoTextos;
                    ctrl.ForeColor = colorLetrasTextos;
                }
                else if (ctrl is PictureBox pictureBox )
                {
                    pictureBox.BackColor = Color.Transparent;
                    pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

                }
                else if(ctrl is ListView listView)
                {
                    listView.BackColor = colorForm;
                }
                else if (ctrl.HasChildren)
                {
                    ColorearComponentes(ctrl);
                }


            }

        }

        private static Color ConvertirRGB(string color)
        {
            try
            {
                string[] rgb = color.Split(';');
                int r = int.Parse(rgb[0]);
                int g = int.Parse(rgb[1]);
                int b = int.Parse(rgb[2]);

                return Color.FromArgb(r, g, b);
            }
            catch (Exception)
            {
                return Color.White;
            }

        }
        private static void AgregarIconoTitulo(Form form,Color colorFondo)
        {
            Size size = new System.Drawing.Size(29, 26);
          
            PictureBox icono = new PictureBox();
  
            icono.Size = size;
            icono.Image = global::Interfaz.Properties.Resources.icon;
            icono.Location = new Point(0, 0);
            icono.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            icono.TabStop = false;
            icono.BackColor = colorFondo;
            icono.SizeMode = PictureBoxSizeMode.Zoom;
            form.Controls.Add(icono);
            icono.BringToFront();


            Label label = new Label();
            label.Text = form.Text;
            label.Font = fuenteLabels;
           
           
            label.Location = new Point(icono.Width, 0);
            label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label.AutoSize = true;
            
            label.ForeColor = colorLabels;
            label.BackColor = colorFondo;   
            form.Controls.Add(label);
            label.BringToFront();


        }
        private static void AgregarBordesPaneles(Form form,Color color)
        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            AgregarPanelBorde(form, color, DockStyle.Top);
            AgregarPanelBorde(form, color, DockStyle.Left);
            AgregarPanelBorde(form, color, DockStyle.Right);
            AgregarPanelBorde(form, color, DockStyle.Bottom);
        }

        private static void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(((Form)((Control)sender).TopLevelControl).Handle, 0x112, 0xf012, 0);
        }

        private static void AgregarPanelBorde(Form form, Color color, DockStyle dock)
        {
            Panel borde = new Panel();
            borde.BackColor = color;
            borde.Dock = dock;
            if (dock == DockStyle.Bottom)
            {
                borde.Height = 5;
                borde.Width = form.Width;
            }
            else if(dock == DockStyle.Top)
            {
                borde.Height = 29;
                borde.Width = form.Width;
                borde.MouseDown += (sender, e) => Panel_MouseDown(sender, e);
            }
            else
            {
                borde.Width = 5;
                borde.Height = form.Height;
            }
            form.Controls.Add(borde);
            borde.BringToFront();
        }
        private static void AgregarBotonesVentana(Form form,Color colorFondo)
        {
            AgregarBotonVentana(form,colorFondo,exitButton:true);
            AgregarBotonVentana(form,colorFondo ,exitButton: false);
            
        }
        private static void AgregarBotonVentana(Form form,Color colorFondo,bool exitButton = true)
        {
            Size size = new System.Drawing.Size(29, 26);
            Point ubicacion = new Point(0,0);

            PictureBox boton = new PictureBox();
            if (exitButton)
            {
               boton.Image = global::Interfaz.Properties.Resources.exit; 
               ubicacion.X = form.Width - size.Width;
               boton.Click += (sender, e) => form.Close();
            }
            else
            {
               boton.Image = global::Interfaz.Properties.Resources.minimizar;
               ubicacion.X = (form.Width - size.Width) - size.Width ;
               boton.Click += (sender, e) => form.WindowState = FormWindowState.Minimized;
            }
            boton.Size = size;
            boton.Location = ubicacion;
            boton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boton.TabStop = false;
            boton.BackColor = colorFondo;
            boton.SizeMode = PictureBoxSizeMode.Zoom;
            boton.Cursor = Cursors.Hand;

            form.Controls.Add(boton);
            boton.BringToFront();

        }



 










    }
}







