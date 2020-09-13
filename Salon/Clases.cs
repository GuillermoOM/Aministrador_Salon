namespace Salon
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Primer_A { get; set; }
        public string Segundo_A { get; set; }
        public string Telefono { get; set; }
    }

    public class Cita
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Cliente { get; set; }
        public string EsCliente { get; set; }
        public string[] Servicios { get; set; }
    }

    public class Estilista
    {
        public string Nombre { get; set; }
        public string Primer_A { get; set; }
        public string Segundo_A { get; set; }
        public int Comision { get; set; }
    }

    public class Servicio
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}
