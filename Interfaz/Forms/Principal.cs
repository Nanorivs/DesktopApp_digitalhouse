using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Dominio;
using Negocio;
using System.Drawing;

namespace Interfaz
{
    
    public partial class Principal : Form
    {
        List<Articulo> listaArticulos = null;
        Dictionary<string,List<string>> opcionesFiltro = null;


        public Principal()
        {
            InitializeComponent();
            Apariencia.PersonalizarForm(this);
        }

        public void VentanaPrincipal()
        {   
            Tareas operacionesDB = new Tareas();
            try
            {
                CargarFiltros();
                listaArticulos = operacionesDB.listarArticulos();
                dgv_Articulos.DataSource = operacionesDB.listarArticulos();
           
                ActualizarDataGridView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void dgv_Articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
            Articulo articulo = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            MostrarProducto mostrarProducto = new MostrarProducto(articulo);
            mostrarProducto.ShowDialog();
            VentanaPrincipal();
        }

        private void dgv_Articulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)//¿Celda valida?
                {
                    dgv_Articulos.ClearSelection();
                    dgv_Articulos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    contMenuStrip_Opciones.Show(Cursor.Position);
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            MostrarProducto modificarProducto = new MostrarProducto(articulo, "modificar");
            modificarProducto.ShowDialog();
            VentanaPrincipal();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            MostrarProducto modificarProducto = new MostrarProducto(articulo, "eliminar");
            modificarProducto.ShowDialog();
            VentanaPrincipal();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProducto agregarProducto = new MostrarProducto(null, "agregar");
            agregarProducto.ShowDialog();
            VentanaPrincipal();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            VentanaPrincipal();
        }

        private void ActualizarDataGridView()
        {
            if (dgv_Articulos.DataSource != null && dgv_Articulos.Rows.Count > 0)
            {
                dgv_Articulos.Visible = true;
                pb_SinResultados.Visible = false;
                dgv_Articulos.Columns["Imagen"].Visible = false;
                dgv_Articulos.Columns["Id"].Visible = false;
                dgv_Articulos.Columns["Precio"].Visible = false;
            }
            else
            {   
                dgv_Articulos.Visible = false;
                pb_SinResultados.Visible = true;
            }
            
        }

        private void btn_Filtro_Click(object sender, EventArgs e)
        {
            Point posicionPantalla = btn_Filtro.PointToScreen(Point.Empty);
            contextMenuStrip_Filtro.Show(posicionPantalla.X, posicionPantalla.Y + btn_Filtro.Height);
        }

    
    }



}




