using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multivista
{
    class MainWindowVM : ObservableObject

    {
        public RelayCommand AbrirVentanaCommand { get; }

        private ServicioNavegacion servicio { get; set; }

        public MainWindowVM()
        {
            AbrirVentanaCommand = new RelayCommand(AbrirVentana);
            servicio = new ServicioNavegacion();
        }

        private void AbrirVentana()
        {
            servicio.AbrirVentanaHija();
        }
    }
}
