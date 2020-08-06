namespace Tarea2
{
    class ProveedorStandar:Persona, IProveedor
    {
        public string Ofrecer(string productos)
        {
            return $"Estoy ofreciendo {productos}";
        }
        public string Repartir(string lugar)
        {
            return $"Realizamos entregas {lugar}";
        }

    }
}
