using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KineMovil.Commands;


namespace KineMovil.ViewModel
{
    class VMCliente : INotifyPropertyChanged
    {
        private string _nombre;
        private string _apelllido;
        private string _dni;
        private string _correo;
        private string _telefono;
        private string _obraSocial;
        private int _sesiones;
        private string _dolor;
        private int _idMusculo;
        private bool _estampillado;

        public string Nombre 
        { 
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged(); }
        }

        public string Apellido 
        {
            get { return _apelllido; }
            set { _apelllido = value; OnPropertyChanged(); }

        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; OnPropertyChanged(); }
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; OnPropertyChanged(); }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; OnPropertyChanged(); }

        }

        public string ObraSocial
        {
            get { return _obraSocial; }
            set { _obraSocial = value; OnPropertyChanged(); }
        }

        public int Sesiones
        {
            get { return _sesiones; }
            set { _sesiones = value; OnPropertyChanged(); }

        }

        public string Dolor
        {
            get { return _dolor; }
            set { _dolor = value; OnPropertyChanged(); }
        }

        public int IdMusculo
        {
            get { return _idMusculo; }
            set { _idMusculo = value; OnPropertyChanged(); }
        }

        public bool Estampillado
        {
            get { return _estampillado; }
            set { _estampillado = value; OnPropertyChanged(); }
        }

        public ICommand AgregarClienteCommand { get; }
        public ICommand EliminarClienteCommand { get; }
        public ICommand ActualizarClienteCommand { get; }


        public VMCliente()
        {
            AgregarClienteCommand = new RelayCommand(param => AgregarCliente());
            EliminarClienteCommand = new RelayCommand(param => EliminarCliente());
            ActualizarClienteCommand = new RelayCommand(param => ActualizarCliente());
        }

        private void AgregarCliente()
        {

        }

        private void EliminarCliente()
        {

        }

        private void ActualizarCliente()
        {

        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
