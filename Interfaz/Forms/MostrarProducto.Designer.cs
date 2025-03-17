using System;

namespace Interfaz
{
    partial class MostrarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Imagen = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Imagen = new System.Windows.Forms.TextBox();
            this.comBox_Categoria = new System.Windows.Forms.ComboBox();
            this.comBox_Marca = new System.Windows.Forms.ComboBox();
            this.numUpDown_Precio = new System.Windows.Forms.NumericUpDown();
            this.txt_PrecioFormateado = new System.Windows.Forms.TextBox();
            this.pb_Articulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.Location = new System.Drawing.Point(60, 111);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(76, 27);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Código";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(52, 55);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(84, 27);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(16, 335);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(120, 27);
            this.lbl_Descripcion.TabIndex = 2;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(68, 277);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(68, 27);
            this.lbl_Marca.TabIndex = 3;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.Location = new System.Drawing.Point(33, 222);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(103, 27);
            this.lbl_Categoria.TabIndex = 4;
            this.lbl_Categoria.Text = "Categoría";
            // 
            // lbl_Imagen
            // 
            this.lbl_Imagen.AutoSize = true;
            this.lbl_Imagen.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Imagen.Location = new System.Drawing.Point(58, 391);
            this.lbl_Imagen.Name = "lbl_Imagen";
            this.lbl_Imagen.Size = new System.Drawing.Size(78, 27);
            this.lbl_Imagen.TabIndex = 5;
            this.lbl_Imagen.Text = "Imagen";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(66, 167);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(70, 27);
            this.lbl_Precio.TabIndex = 6;
            this.lbl_Precio.Text = "Precio";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Location = new System.Drawing.Point(626, 424);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(97, 31);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(142, 55);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(262, 26);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(142, 111);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(262, 26);
            this.txt_Codigo.TabIndex = 1;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(141, 336);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(262, 26);
            this.txt_Descripcion.TabIndex = 5;
            // 
            // txt_Imagen
            // 
            this.txt_Imagen.Location = new System.Drawing.Point(141, 388);
            this.txt_Imagen.Name = "txt_Imagen";
            this.txt_Imagen.Size = new System.Drawing.Size(262, 26);
            this.txt_Imagen.TabIndex = 6;
            this.txt_Imagen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Imagen_KeyDown);
            this.txt_Imagen.Leave += new System.EventHandler(this.txt_Imagen_Leave);
            // 
            // comBox_Categoria
            // 
            this.comBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_Categoria.FormattingEnabled = true;
            this.comBox_Categoria.Location = new System.Drawing.Point(141, 223);
            this.comBox_Categoria.Name = "comBox_Categoria";
            this.comBox_Categoria.Size = new System.Drawing.Size(262, 28);
            this.comBox_Categoria.TabIndex = 3;
            // 
            // comBox_Marca
            // 
            this.comBox_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_Marca.FormattingEnabled = true;
            this.comBox_Marca.Location = new System.Drawing.Point(141, 278);
            this.comBox_Marca.Name = "comBox_Marca";
            this.comBox_Marca.Size = new System.Drawing.Size(262, 28);
            this.comBox_Marca.TabIndex = 4;
            // 
            // numUpDown_Precio
            // 
            this.numUpDown_Precio.Location = new System.Drawing.Point(141, 167);
            this.numUpDown_Precio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDown_Precio.Name = "numUpDown_Precio";
            this.numUpDown_Precio.Size = new System.Drawing.Size(263, 26);
            this.numUpDown_Precio.TabIndex = 2;
            // 
            // txt_PrecioFormateado
            // 
            this.txt_PrecioFormateado.Enabled = false;
            this.txt_PrecioFormateado.Location = new System.Drawing.Point(141, 166);
            this.txt_PrecioFormateado.Name = "txt_PrecioFormateado";
            this.txt_PrecioFormateado.ReadOnly = true;
            this.txt_PrecioFormateado.Size = new System.Drawing.Size(262, 26);
            this.txt_PrecioFormateado.TabIndex = 2;
            this.txt_PrecioFormateado.Visible = false;
            // 
            // pb_Articulo
            // 
            this.pb_Articulo.Location = new System.Drawing.Point(436, 74);
            this.pb_Articulo.Name = "pb_Articulo";
            this.pb_Articulo.Size = new System.Drawing.Size(273, 300);
            this.pb_Articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Articulo.TabIndex = 7;
            this.pb_Articulo.TabStop = false;
            // 
            // MostrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(735, 467);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Imagen);
            this.Controls.Add(this.pb_Articulo);
            this.Controls.Add(this.txt_Imagen);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.comBox_Marca);
            this.Controls.Add(this.comBox_Categoria);
            this.Controls.Add(this.txt_PrecioFormateado);
            this.Controls.Add(this.numUpDown_Precio);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Marca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MostrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.MostrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Imagen;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.PictureBox pb_Articulo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Imagen;
        private System.Windows.Forms.ComboBox comBox_Categoria;
        private System.Windows.Forms.ComboBox comBox_Marca;
        private System.Windows.Forms.NumericUpDown numUpDown_Precio;
        private System.Windows.Forms.TextBox txt_PrecioFormateado;
    }
}