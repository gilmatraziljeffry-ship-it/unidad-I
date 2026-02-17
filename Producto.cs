using System;

namespace ProductoApp
{
    public class Producto
    {
        public int Id { get; }
        public string Nombre { get; }

        private double precio;
        public double Precio
        {
            get => precio;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Precio inválido ({value}). No se aplicó el cambio.");
                    return;
                }
                precio = value;
            }
        }

        private int stock;
        public int Stock
        {
            get => stock;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Stock inválido ({value}). No se aplicó el cambio.");
                    return;
                }
                stock = value;
            }
        }

        public Producto(int id, string nombre, double precioInicial, int stockInicial)
        {
            Id = id;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            precio = precioInicial >= 0 ? precioInicial : 0;
            stock = stockInicial >= 0 ? stockInicial : 0;
        }

        public void MostrarProducto()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio:0.00}");
            Console.WriteLine($"Stock: {Stock}");
        }

        public void DescontarStock(int cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("Cantidad inválida.");
                return;
            }
            if (cantidad > Stock)
            {
                Console.WriteLine($"No hay suficiente stock para descontar {cantidad}. Stock actual: {Stock}");
                return;
            }
            Stock -= cantidad;
            Console.WriteLine($"Se descontaron {cantidad} unidades. Stock restante: {Stock}");
        }
    }
}
