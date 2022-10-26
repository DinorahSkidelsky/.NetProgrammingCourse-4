using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGeneros.Items.Add("Femenino");
            cboGeneros.Items.Add("Masculino");
            cboGeneros.Items.Add("No-Binario");
            cboGeneros.Items.Add("Bigenero");
            cboGeneros.Items.Add("Otros");
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;

            string autor = textAutor.Text;

            string genero = cboGeneros.Text;

            string paginas = textPaginas.Text;

            string importado = checkBoxImportado.Checked ? ("Importado") : ("Nacional");

            string precio = textPrecio.Text;

            listaRegistros.Items.Add(nombre + " - " + autor + " - " + genero + " - " + paginas + " - " + importado + " - " + precio);
        }
    }
}
