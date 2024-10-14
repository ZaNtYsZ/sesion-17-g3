using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using sesion_17_g3.Modelos;

namespace sesion_17_g3.Servicios
{
    internal class ProductoServicio
    {
        List<Producto> Productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public Producto BuscarProducto(Producto producto)
        {
            return Productos.Find(p => p.ID == producto.ID);
        }

        public void EliminarProducto(Producto producto)
        {
            try
            {
                Productos.Remove(producto);
            }catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

        public void ActualizarProducto(Producto producto, int id)
        { 
            int index = Productos.FindIndex(p => p.ID == id);

            if (index != -1)
            {
                Productos[index] = producto;
            }
        }

    }
}
