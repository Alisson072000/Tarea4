namespace Tarea2
{
    public class PanaderoCuidadoso:Persona , IPanadero, IComparar<PanaderoCuidadoso>
    {
        public string Hornear(string tipoPan)
        {
            return $"Estoy horneando el pan {tipoPan} con mucho cuidado";
        }
        public string Preparar(string tipoIngredientes)
        {
            return $"Estoy preparando la mezcla del pan con los ingredientes {tipoIngredientes} de la mejor calidad";
        }
        public string Elaborar(string tiposPanes)
        {
            return $"Yo elaboro varios diseños de panes como {tiposPanes} con moldes únicos";
        }

        public int Comparar(PanaderoCuidadoso primero, PanaderoCuidadoso segundo)
        {
            return primero.Apellido.CompareTo(segundo.Apellido);
        }
    }
}
