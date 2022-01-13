using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Multivista
{
    class ServicioNavegacion
    {
        
        internal UserControl AbrirUC1Servicio()
        {
            return new UserControl1();
        }

        internal UserControl AbrirUC2Servicio()
        {
            return new UserControl2();
        }
    }
}
