using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class Cuenta
    {
        public object Numero { get; internal set; }
        public object CodigoSocio { get; internal set; }
        public object SaldoTotal { get; internal set; }
        public object CodigoSocioNavigation { get; internal set; }
        public object Estado { get; internal set; }

        public partial class Cuentas
        {
            public string Numero { get; set; }
            public string SaldoTotal { get; set; }
            public string CodigoSocio { get; set; }
            public int Estado { get; set; }

            public virtual Socio CodigoSocioNavigation { get; set; }
        }
    }
}
