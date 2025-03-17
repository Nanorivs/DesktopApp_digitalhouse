namespace Interfaz
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contMenuStrip_Opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Filtro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.listView_FiltrosSeleccionados = new System.Windows.Forms.ListView();
            this.btn_Filtro = new System.Windows.Forms.Button();
            this.txt_BarraBusqueda = new System.Windows.Forms.TextBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_SinResultados = new System.Windows.Forms.PictureBox();
            this.contMenuStrip_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SinResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // contMenuStrip_Opciones
            // 
            this.contMenuStrip_Opciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contMenuStrip_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.contMenuStrip_Opciones.Name = "contMenuStrip_Opciones";
            this.contMenuStrip_Opciones.Size = new System.Drawing.Size(126, 70);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // contextMenuStrip_Filtro
            // 
            this.contextMenuStrip_Filtro.Name = "contextMenuStrip_Filtro";
            this.contextMenuStrip_Filtro.Size = new System.Drawing.Size(61, 4);
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.AllowUserToAddRows = false;
            this.dgv_Articulos.AllowUserToDeleteRows = false;
            this.dgv_Articulos.AllowUserToResizeColumns = false;
            this.dgv_Articulos.AllowUserToResizeRows = false;
            this.dgv_Articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Articulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Articulos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Articulos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Articulos.Location = new System.Drawing.Point(23, 134);
            this.dgv_Articulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Articulos.MultiSelect = false;
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.ReadOnly = true;
            this.dgv_Articulos.RowHeadersVisible = false;
            this.dgv_Articulos.RowHeadersWidth = 51;
            this.dgv_Articulos.RowTemplate.Height = 24;
            this.dgv_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Articulos.Size = new System.Drawing.Size(993, 260);
            this.dgv_Articulos.TabIndex = 3;
            this.dgv_Articulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Articulos_CellDoubleClick);
            this.dgv_Articulos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Articulos_CellMouseClick);
            // 
            // listView_FiltrosSeleccionados
            // 
            this.listView_FiltrosSeleccionados.AllowDrop = true;
            this.listView_FiltrosSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_FiltrosSeleccionados.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_FiltrosSeleccionados.ForeColor = System.Drawing.Color.Transparent;
            this.listView_FiltrosSeleccionados.FullRowSelect = true;
            this.listView_FiltrosSeleccionados.HideSelection = false;
            this.listView_FiltrosSeleccionados.LabelWrap = false;
            this.listView_FiltrosSeleccionados.Location = new System.Drawing.Point(23, 451);
            this.listView_FiltrosSeleccionados.Margin = new System.Windows.Forms.Padding(5);
            this.listView_FiltrosSeleccionados.MultiSelect = false;
            this.listView_FiltrosSeleccionados.Name = "listView_FiltrosSeleccionados";
            this.listView_FiltrosSeleccionados.Size = new System.Drawing.Size(460, 111);
            this.listView_FiltrosSeleccionados.TabIndex = 2;
            this.listView_FiltrosSeleccionados.TabStop = false;
            this.listView_FiltrosSeleccionados.UseCompatibleStateImageBehavior = false;
            this.listView_FiltrosSeleccionados.View = System.Windows.Forms.View.Details;
            this.listView_FiltrosSeleccionados.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_FiltrosSeleccionados_ItemSelectionChanged);
            this.listView_FiltrosSeleccionados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView_FiltrosSeleccionados_MouseMove);
            // 
            // btn_Filtro
            // 
            this.btn_Filtro.BackColor = System.Drawing.Color.White;
            this.btn_Filtro.FlatAppearance.BorderSize = 0;
            this.btn_Filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filtro.Location = new System.Drawing.Point(480, 415);
            this.btn_Filtro.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Filtro.Name = "btn_Filtro";
            this.btn_Filtro.Size = new System.Drawing.Size(118, 26);
            this.btn_Filtro.TabIndex = 1;
            this.btn_Filtro.Text = "Filtro";
            this.btn_Filtro.UseVisualStyleBackColor = false;
            this.btn_Filtro.Click += new System.EventHandler(this.btn_Filtro_Click);
            // 
            // txt_BarraBusqueda
            // 
            this.txt_BarraBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BarraBusqueda.Location = new System.Drawing.Point(23, 415);
            this.txt_BarraBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BarraBusqueda.Name = "txt_BarraBusqueda";
            this.txt_BarraBusqueda.Size = new System.Drawing.Size(460, 26);
            this.txt_BarraBusqueda.TabIndex = 0;
            this.txt_BarraBusqueda.TextChanged += new System.EventHandler(this.txt_BarraBusqueda_TextChanged);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Interfaz.Properties.Resources.logo;
            this.pb_logo.Location = new System.Drawing.Point(11, 25);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(439, 102);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 13;
            this.pb_logo.TabStop = false;
            // 
            // pb_SinResultados
            // 
            this.pb_SinResultados.BackColor = System.Drawing.Color.DimGray;
            this.pb_SinResultados.Image = global::Interfaz.Properties.Resources.noresults;
            this.pb_SinResultados.Location = new System.Drawing.Point(260, 74);
            this.pb_SinResultados.Margin = new System.Windows.Forms.Padding(5);
            this.pb_SinResultados.Name = "pb_SinResultados";
            this.pb_SinResultados.Size = new System.Drawing.Size(479, 334);
            this.pb_SinResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SinResultados.TabIndex = 17;
            this.pb_SinResultados.TabStop = false;
            this.pb_SinResultados.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1027, 625);
            this.Controls.Add(this.dgv_Articulos);
            this.Controls.Add(this.listView_FiltrosSeleccionados);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.btn_Filtro);
            this.Controls.Add(this.txt_BarraBusqueda);
            this.Controls.Add(this.pb_SinResultados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital House";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.contMenuStrip_Opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SinResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contMenuStrip_Opciones;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Filtro;
        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.ListView listView_FiltrosSeleccionados;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_Filtro;
        private System.Windows.Forms.TextBox txt_BarraBusqueda;
        private System.Windows.Forms.PictureBox pb_SinResultados;
    }
}

