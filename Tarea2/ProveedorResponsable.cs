namespace Tarea2
{
    class ProveedorResponsable:Persona ,IProveedor
    {
        public string Ofrecer(string productos)
        {
            return $"Estoy ofreciendo {productos} con todas las medidas de precaución";
        }
        public string Repartir(string lugar)
        {
            return $"Realizamos entregas {lugar} con todas sus entregas a tiempo" ;
        }
    }
}
