using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Multivista
{
    class MainWindowVM : ObservableObject

    {
        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion, value); }
        }


        public RelayCommand AbrirUC1Command { get; }
        public RelayCommand AbrirUC2Command { get; }

        private ServicioNavegacion servicio { get; set; }

        public MainWindowVM()
        {
            AbrirUC1Command = new RelayCommand(AbrirUC1);
            AbrirUC2Command = new RelayCommand(AbrirUC2);
            servicio = new ServicioNavegacion();
            Opcion = servicio.AbrirUC1Servicio();
        }

        private void AbrirUC1()
        {
            Opcion = servicio.AbrirUC1Servicio();
        }

        private void AbrirUC2()
        {
            Opcion = servicio.AbrirUC2Servicio();
        }
    }
}
