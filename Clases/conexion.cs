using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolar.Clases
{
    class conexion
    {
        public string conn()
        {
            string miconexion = (@"Data Source=LAPTOP-5RRC2HD8, 2000;Initial Catalog=cescolar; Persist Security Info=True; User ID=sa;Password=melendrez");
            return miconexion;
        }
    }
}
