using Interfaz.Helpers;
using Negocio;
using Negocio.Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz
{
    public partial class Principal
    {
        private Dictionary<string, List<string>> tiposFiltro = null;

        private void CargarFiltros()
        {
            CargarTiposFiltroDiccionario();
            CargarFiltroToolStripMenu();
            CargarFiltroListView();
        }

        private void CargarTiposFiltroDiccionario()
        {
            Tareas operacionesDB = new Tareas();

            List<string> listaCategorias = Utilidades.ProcesarListaComoStrings(operacionesDB.listarCategorias());
            List<string> listaMarcas = Utilidades.ProcesarListaComoStrings(operacionesDB.listarMarcas());

            this.tiposFiltro = new Dictionary<string, List<string>>
                                {
                                    {"Categoria",listaCategorias},
                                    {"Marca", listaMarcas},
                                    {"Precio hasta $",null}
                                };

        }

        private void CargarFiltroToolStripMenu()
        {
            contextMenuStrip_Filtro.Items.Clear();
            foreach (var tipoFiltro in tiposFiltro)
            {
                string nombreFiltro = tipoFiltro.Key;
                ToolStripMenuItem filtro = new ToolStripMenuItem(nombreFiltro);

                if (nombreFiltro == "Precio hasta $")
                {
                    ToolStripTextBox textBoxPrecio = new ToolStripTextBox();
                    Validaciones.SoloNumeros(textBoxPrecio);
                    textBoxPrecio.AutoSize = false;
                    textBoxPrecio.Width = 80;
                    textBoxPrecio.KeyPress += TextBoxPrecio_KeyPress;
                    textBoxPrecio.MaxLength = 9;


                    filtro.DropDownItems.Add(textBoxPrecio);
                }
                else
                {
                    foreach (var subSeccion in tipoFiltro.Value)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(subSeccion);
                        item.Click += (sender, e) => AgregarFiltroListView(sender, nombreFiltro);
                        filtro.DropDownItems.Add(item);
                    }

                }
                contextMenuStrip_Filtro.Items.Add(filtro);
            }
        }

        private void CargarFiltroListView()
        {
            listView_FiltrosSeleccionados.Items.Clear();
            listView_FiltrosSeleccionados.BackColor = this.BackColor;
            listView_FiltrosSeleccionados.HeaderStyle = ColumnHeaderStyle.None;

            listView_FiltrosSeleccionados.Columns.Add("Filtro", 100, HorizontalAlignment.Left);
            listView_FiltrosSeleccionados.Columns.Add("Valor", 100, HorizontalAlignment.Left);
        }
        private void txt_BarraBusqueda_TextChanged(object sender, EventArgs e)
        {
            Tareas tareas = new Tareas();
            dgv_Articulos.DataSource = null;
            dgv_Articulos.DataSource = RealizarBusqueda();
            ActualizarDataGridView();
        }
      
        private List<Articulo> RealizarBusqueda()
        {
            string textoBarra = txt_BarraBusqueda.Text.Trim();

            List<Articulo> listaFiltrada = new List<Articulo>();
            bool hayFiltros = false;

            if (listView_FiltrosSeleccionados.Items.Count > 0)
            {
                hayFiltros = true;

                foreach (Articulo articulo in listaArticulos)
                {   
                    bool categoria = true;
                    bool marca = true;
                    bool precio = true;

                    foreach (ListViewItem item in listView_FiltrosSeleccionados.Items)
                    {
                        string filtro = item.SubItems[0].Text;
                        string valor = item.SubItems[1].Text;
                       
                        if (filtro == "Marca")
                        {
                            marca = articulo.Marca.Descripcion == valor;
                            if (!marca)
                                break;
                        }
                        if (filtro == "Precio hasta $")
                        {
                            precio = articulo.Precio <= long.Parse(valor);
                            if(!precio)
                                break;
                        }
                        if(filtro == "Categoria")
                        {
                            categoria = articulo.Categoria.Descripcion == valor;
                            if(!categoria)
                                break;  
                        }
                    }

                    if (categoria && precio && marca)
                        listaFiltrada.Add(articulo);
                }
            }

            if ( (hayFiltros && listaFiltrada.Count > 0) ^ (!hayFiltros && listaFiltrada.Count == 0))
            {
                if (listaFiltrada.Count == 0)
                    listaFiltrada = listaArticulos;

                if (textoBarra.Length > 2)
                {
                    var propiedades = typeof(Articulo).GetProperties();
                    listaFiltrada = listaFiltrada.Where(x => propiedades.Any(prop => prop.GetValue(x)?.ToString().ToUpper().Contains(textoBarra.ToUpper()) == true)).ToList();
                }
                
            }
        

            return listaFiltrada;
        }
       
        private void AgregarFiltroListView(object sender, string nombreFiltro)
        {
        string valorElegido = sender.ToString();

        foreach (ListViewItem filtroRegistrado in listView_FiltrosSeleccionados.Items)
        {
            if (filtroRegistrado.Text == nombreFiltro)
            {
                filtroRegistrado.Remove();
                break;
            }
        }

        ListViewItem filtro = new ListViewItem(nombreFiltro);
        filtro.SubItems.Add(valorElegido);
        listView_FiltrosSeleccionados.Items.Add(filtro);
        listView_FiltrosSeleccionados.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        dgv_Articulos.DataSource = null;
        dgv_Articulos.DataSource = RealizarBusqueda();
        ActualizarDataGridView();

        } 
        
        private void listView_FiltrosSeleccionados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                listView_FiltrosSeleccionados.Items[e.ItemIndex].Remove();

                dgv_Articulos.DataSource = null;
                dgv_Articulos.DataSource = RealizarBusqueda();
                ActualizarDataGridView();
            }
        }

        private void listView_FiltrosSeleccionados_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in listView_FiltrosSeleccionados.Items)
            {
                item.ForeColor = Color.White;
            }

            ListViewHitTestInfo hit = listView_FiltrosSeleccionados.HitTest(e.Location);

            if (hit.Item != null)
            {
                listView_FiltrosSeleccionados.Items[hit.Item.Index].ForeColor = Color.Red;
                listView_FiltrosSeleccionados.Cursor = Cursors.Hand;
            }

            else
                listView_FiltrosSeleccionados.Cursor = Cursors.Default;

        }

        private void TextBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && ((ToolStripTextBox)sender).Text.Trim().Length > 0 )
            {  
                AgregarFiltroListView(sender,"Precio hasta $");
                ((ToolStripTextBox)sender).Text = "";

            }
        }
       



    }
}
