using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Models.Acreditaciones
{
    public class AcreditacionDto
    {
        public int Id { get; set; }
        public string NroRuc { get; set; } = default!;
        public string RazonSocial { get; set; } = default!;
        public string InicioVigencia { get; set; } = default!;
        public string FinVigencia { get; set; } = default!;
        public string Estado { get; set; } = default!;
    }
}
