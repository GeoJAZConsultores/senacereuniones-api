namespace Jazani.Senace.Reuniones.Dominio.Acreditaciones.Models
{
    public class Acreditacion
    {
        public int Id { get; set; }
        public string NroRuc { get; set; } = default!;
        public string RazonSocial { get; set; } = default!;
        public string InicioVigencia { get; set; } = default!;
        public string FinVigencia { get; set; } = default!;
        public string Estado {  get; set; } = default!;
    }
}
