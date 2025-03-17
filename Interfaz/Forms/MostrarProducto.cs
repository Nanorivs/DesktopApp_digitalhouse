using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Dominio;
using Negocio;
using Interfaz.Helpers;

namespace Interfaz
{
    public partial class MostrarProducto : Form
    {
        Articulo articulo = null;
        string accion = null;
        bool modoEdicion = false;
        
        /// <summary>
        /// Keys: 
        /// "modificar" "eliminar" "agregar".
        /// Default: mostrar
        /// </summary>
        public MostrarProducto( Articulo articulo , string accion = null)
        {
            InitializeComponent();
            Apariencia.PersonalizarForm(this);

            this.articulo = articulo;

            if (accion != null)
            {
                this.accion = accion.ToLower();
                btn_Aceptar.Text = this.accion;
            }

            if(accion == "agregar" || accion == "modificar")
                modoEdicion = true;  
        }
        
        private void MostrarProducto_Load(object sender, EventArgs e)
        {
            try 
            { 
                Tareas tareas = new Tareas();

                comBox_Marca.DataSource = tareas.listarMarcas();
                comBox_Marca.ValueMember = "Id";
                comBox_Marca.DisplayMember = "Descripcion";

                comBox_Categoria.DataSource = tareas.listarCategorias();
                comBox_Categoria.ValueMember = "Id";
                comBox_Categoria.DisplayMember = "Descripcion";

                string imagenArticulo = null;
                
                if (articulo != null)
                { 
                    txt_Codigo.Text = articulo.Codigo;
                    txt_Descripcion.Text = articulo.Descripcion;
                    txt_Imagen.Text = articulo.Imagen;
                    imagenArticulo = articulo.Imagen;
                    txt_Nombre.Text = articulo.Nombre;
                    numUpDown_Precio.Value = articulo.Precio;
                    comBox_Categoria.SelectedValue = articulo.Categoria.Id;
                    comBox_Marca.SelectedValue = articulo.Marca.Id;
                    txt_PrecioFormateado.Text = articulo.PrecioFormateado;
   
                    if (!modoEdicion)
                    {
                        txt_PrecioFormateado.Visible = true;
                        Utilidades.SoloLectura(this);
                    }
                    if (accion == null)
                    {   
                        lbl_Imagen.Visible = false;
                        txt_Imagen.Visible = false;
                    }
                }
                
                Utilidades.CargarImagen(pb_Articulo, imagenArticulo,url:true);

            }
            catch(Exception error) 
                { throw error; }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {   
            Tareas tareas = new Tareas();
            List<string> opciones = new List<string> { "agregar","modificar","eliminar"};

            if (opciones.Contains(accion) && Validaciones.ValidarDecision(accion))
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Marca = (Marca)comBox_Marca.SelectedItem;
                articulo.Categoria = (Categoria)comBox_Categoria.SelectedItem;
                articulo.Codigo = txt_Codigo.Text;
                articulo.Nombre = txt_Nombre.Text;
                articulo.Descripcion = txt_Descripcion.Text;
                articulo.Imagen = txt_Imagen.Text;
                articulo.Precio = numUpDown_Precio.Value;

                switch (accion)
                {
                    case "agregar":
                        tareas.agregarArticulo(articulo);
                        break;

                    case "modificar":
                        tareas.modificarArticulo(articulo);
                        break;

                    case "eliminar":
                        tareas.eliminarArticulo(articulo.Id);
                        break;
                }
            }
            Close();
        }
           
        private void txt_Imagen_Leave(object sender, EventArgs e)
        {
            Utilidades.CargarImagen(pb_Articulo, txt_Imagen.Text,url:true);
        }

        private void txt_Imagen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
                Utilidades.CargarImagen(pb_Articulo,txt_Imagen.Text,url: true);
        }

     
    }
}
