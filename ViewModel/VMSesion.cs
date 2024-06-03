using KineMovil.Commands;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KineMovil.ViewModel
{
    internal class VMSesion :INotifyPropertyChanged
    {
        private int _idClinete;
        private DateTime _fecha;

        public int IdCliente
        {
            get { return _idClinete; }
            set { _idClinete = value; OnPropertyChanged(); }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; OnPropertyChanged(); }
        }

        public ICommand AgregarSesionCommand { get; }
        public ICommand EliminarSesionCommand { get; }
        public ICommand ActualizarSesionCommand { get; }

        public VMSesion()
        {
            AgregarSesionCommand = new RelayCommand(param => AgregarSesion());
            EliminarSesionCommand = new RelayCommand(param => EliminarSesion());
            ActualizarSesionCommand = new RelayCommand(param => ActualizarSesion());

        }

        private void AgregarSesion()
        {

        }

        private void EliminarSesion()
        {

        }

        private void ActualizarSesion()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
