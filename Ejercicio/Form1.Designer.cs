
namespace Ejercicio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxIngresarLibro = new System.Windows.Forms.GroupBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelImportado = new System.Windows.Forms.Label();
            this.labelPaginas = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textPaginas = new System.Windows.Forms.TextBox();
            this.checkBoxImportado = new System.Windows.Forms.CheckBox();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageIngreso = new System.Windows.Forms.TabPage();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.listaRegistros = new System.Windows.Forms.ListBox();
            this.groupBoxIngresarLibro.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPageIngreso.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(238, 266);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 0;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(101, 266);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBoxIngresarLibro
            // 
            this.groupBoxIngresarLibro.Controls.Add(this.labelPrecio);
            this.groupBoxIngresarLibro.Controls.Add(this.labelImportado);
            this.groupBoxIngresarLibro.Controls.Add(this.labelPaginas);
            this.groupBoxIngresarLibro.Controls.Add(this.labelGenero);
            this.groupBoxIngresarLibro.Controls.Add(this.labelAutor);
            this.groupBoxIngresarLibro.Controls.Add(this.labelNombre);
            this.groupBoxIngresarLibro.Controls.Add(this.textNombre);
            this.groupBoxIngresarLibro.Controls.Add(this.textPrecio);
            this.groupBoxIngresarLibro.Controls.Add(this.textPaginas);
            this.groupBoxIngresarLibro.Controls.Add(this.checkBoxImportado);
            this.groupBoxIngresarLibro.Controls.Add(this.cboGeneros);
            this.groupBoxIngresarLibro.Controls.Add(this.textAutor);
            this.groupBoxIngresarLibro.Controls.Add(this.buttonIngresar);
            this.groupBoxIngresarLibro.Controls.Add(this.buttonCancelar);
            this.groupBoxIngresarLibro.Location = new System.Drawing.Point(6, 6);
            this.groupBoxIngresarLibro.Name = "groupBoxIngresarLibro";
            this.groupBoxIngresarLibro.Size = new System.Drawing.Size(587, 355);
            this.groupBoxIngresarLibro.TabIndex = 2;
            this.groupBoxIngresarLibro.TabStop = false;
            this.groupBoxIngresarLibro.Text = "Ingresar Libro";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(112, 203);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 15);
            this.labelPrecio.TabIndex = 14;
            this.labelPrecio.Text = "Precio";
            // 
            // labelImportado
            // 
            this.labelImportado.AutoSize = true;
            this.labelImportado.Location = new System.Drawing.Point(89, 175);
            this.labelImportado.Name = "labelImportado";
            this.labelImportado.Size = new System.Drawing.Size(63, 15);
            this.labelImportado.TabIndex = 13;
            this.labelImportado.Text = "Importado";
            // 
            // labelPaginas
            // 
            this.labelPaginas.AutoSize = true;
            this.labelPaginas.Location = new System.Drawing.Point(104, 148);
            this.labelPaginas.Name = "labelPaginas";
            this.labelPaginas.Size = new System.Drawing.Size(48, 15);
            this.labelPaginas.TabIndex = 12;
            this.labelPaginas.Text = "Paginas";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(107, 116);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 11;
            this.labelGenero.Text = "Genero";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(115, 87);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(37, 15);
            this.labelAutor.TabIndex = 10;
            this.labelAutor.Text = "Autor";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(101, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.AccessibleName = "";
            this.textNombre.Location = new System.Drawing.Point(158, 53);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 2;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(158, 200);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 23);
            this.textPrecio.TabIndex = 8;
            // 
            // textPaginas
            // 
            this.textPaginas.Location = new System.Drawing.Point(158, 145);
            this.textPaginas.Name = "textPaginas";
            this.textPaginas.Size = new System.Drawing.Size(100, 23);
            this.textPaginas.TabIndex = 7;
            // 
            // checkBoxImportado
            // 
            this.checkBoxImportado.AutoSize = true;
            this.checkBoxImportado.Location = new System.Drawing.Point(158, 175);
            this.checkBoxImportado.Name = "checkBoxImportado";
            this.checkBoxImportado.Size = new System.Drawing.Size(35, 19);
            this.checkBoxImportado.TabIndex = 6;
            this.checkBoxImportado.Text = "Si";
            this.checkBoxImportado.UseVisualStyleBackColor = true;
            // 
            // cboGeneros
            // 
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(158, 113);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(121, 23);
            this.cboGeneros.TabIndex = 4;
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(158, 84);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(100, 23);
            this.textAutor.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TabControl
            // 
            this.TabControl.AccessibleDescription = "";
            this.TabControl.AccessibleName = "";
            this.TabControl.Controls.Add(this.tabPageIngreso);
            this.TabControl.Controls.Add(this.tabPageLista);
            this.TabControl.Location = new System.Drawing.Point(57, 19);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(699, 419);
            this.TabControl.TabIndex = 3;
            // 
            // tabPageIngreso
            // 
            this.tabPageIngreso.Controls.Add(this.groupBoxIngresarLibro);
            this.tabPageIngreso.Location = new System.Drawing.Point(4, 24);
            this.tabPageIngreso.Name = "tabPageIngreso";
            this.tabPageIngreso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIngreso.Size = new System.Drawing.Size(691, 391);
            this.tabPageIngreso.TabIndex = 0;
            this.tabPageIngreso.Text = "Ingreso";
            this.tabPageIngreso.UseVisualStyleBackColor = true;
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.listaRegistros);
            this.tabPageLista.Location = new System.Drawing.Point(4, 24);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(691, 391);
            this.tabPageLista.TabIndex = 1;
            this.tabPageLista.Text = "Lista";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // listaRegistros
            // 
            this.listaRegistros.FormattingEnabled = true;
            this.listaRegistros.ItemHeight = 15;
            this.listaRegistros.Location = new System.Drawing.Point(21, 23);
            this.listaRegistros.Name = "listaRegistros";
            this.listaRegistros.Size = new System.Drawing.Size(497, 319);
            this.listaRegistros.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Gestion de Libros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxIngresarLibro.ResumeLayout(false);
            this.groupBoxIngresarLibro.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPageIngreso.ResumeLayout(false);
            this.tabPageLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBoxIngresarLibro;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.CheckBox checkBoxImportado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textPaginas;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelImportado;
        private System.Windows.Forms.Label labelPaginas;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageIngreso;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.ListBox listaRegistros;
    }
}

