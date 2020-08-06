namespace Tarea2
{
    class Panaderia
    {
        int id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


        private Empleado trabajador;
        public Empleado Trabajador
        {
            get { return trabajador; }
            set
            {
                trabajador = value;
                trabajador.Trabaja = this;
            }
        }
        public IPanadero Panadero { get; set; }
        public IProveedor Proveedor { get; set; }


        public string Informacion()
        {
            return $"La Panaderia {Nombre}" +
                $" esta ubicada {Direccion} puedes contactarnos {Telefono} ";
        }
        public string Producir()
        {
            return $"La Panaderia {Nombre} produce varios tipos de panes semanales\n";
        }
        public string Producir(string parametro)
        {
            return $"La Panaderia {Nombre} produce varios tipos de panes mensuales\n";
        }
        public string Realizar()
        {
            var resltadoPreparar = Panadero.Preparar("la mezcla del pan");
            var resltadoHornear = Panadero.Hornear("pan de Chocolate");
            var resltadoElaborar = Panadero.Elaborar("el pan de queso");
            return $"\n{resltadoPreparar}\n{resltadoHornear}\n{resltadoElaborar}\n";
        }
        public string Proveer()
        {
            var resltadoOfrecer = Proveedor.Ofrecer("productos para panaderias ");
            var resltadoRepartir = Proveedor.Repartir("en toda la ciudad de Quito");
            return $"\n{ resltadoOfrecer}\n{resltadoRepartir}\n";
        }



    }
}
