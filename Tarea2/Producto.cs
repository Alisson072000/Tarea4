namespace Tarea2
{
    class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public float Calorias { get; set; }
        public Panaderia PanaderiaProductos { get; set; }
        public string Informacion()
        {
            return $"El producto {Nombre} contiene {Calorias} esta elaborado con {Ingredientes} ";
        }

    }
    
    
}

