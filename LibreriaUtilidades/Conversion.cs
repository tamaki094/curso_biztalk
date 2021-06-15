using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUtilidades
{
    public class Conversion
    {
        public string ObtenerTipoDocumento(int tipoId)
        {
            switch (tipoId)
            {
                case 1:
                    return "CC";
                case 2:
                    return "NIT";
                case 3:
                    return "CE";
                default:
                    return "CC";
            }
        }
    }
}
