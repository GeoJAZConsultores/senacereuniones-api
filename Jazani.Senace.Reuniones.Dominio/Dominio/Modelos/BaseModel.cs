namespace Jazani.Senace.Reuniones.Dominio.Dominio.Modelos
{
    public class BaseModel<ID>
    {
        public ID Id { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public bool State { get; set; } = true;
    }
}
