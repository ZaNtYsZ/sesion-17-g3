using sesion_17_g3.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sesion_17_g3.Modelos;

namespace sesion_17_g3.Formularios
{
    public partial class ProductoFDM : Form
    {
        ProductoServicio productos;
        public ProductoFDM()
        {
            InitializeComponent();
            productos = new ProductoServicio();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.ID = int.Parse(txtID.Text);
            prod.Nombre = txtNombre.Text;
            prod.Descripcion = txtDescripcion.Text;
            prod.Precio = double.Parse(tbPrecio.Text);

        }
    }
}
