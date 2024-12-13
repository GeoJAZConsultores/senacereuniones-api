namespace Jazani.Senace.Reuniones.Dominio.Dominio
{
    public class MailSettings
    {
        public string EmailFrom { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public int Port { get; set; }
        public bool Ssl { get; set; }
        public string Subject { get; set; }
        public string SubjectUser { get; set; }
        public List<string> Emails { get; set; }

        public bool UseDefaultCredentials { get; set; }
    }
}
