﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multivista
{
    class ServicioNavegacion
    {
        public void AbrirVentanaHija()
        {
            VentanaHija nueva = new VentanaHija();
            nueva.ShowDialog();

        }
    }
}
