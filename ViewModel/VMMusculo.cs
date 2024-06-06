using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;
using KineMovil.Model;

namespace KineMovil.ViewModel
{
    class VMMusculo : INotifyPropertyChanged
    {

        private string _nombre;
        private byte[] _puntoGatillo;
        private int _idParte;
        private ImageSource _imageSource;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value;
                OnPropertyChanged();
            }
        }

        public byte[] PuntoGatillo
        {
            get { return _puntoGatillo; }
            set
            {
                _puntoGatillo = value;
                OnPropertyChanged();
                ImageSource = ImageSource.FromStream(() => new MemoryStream(_puntoGatillo));
            }
        }

        public ImageSource ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        public int IdParte
        {
            get { return _idParte; }
            set { _idParte = value;
                OnPropertyChanged();}   
        }

        /*

        public ICommand AgregarMusculoCommand { get; }
        public ICommand EliminarMusculoCommand { get; }
        public ICommand ActualizarMusculoCommand { get; }

        public MusculoViewModel()
        {
            AgregarMusculoCommand = new RelayCommand(AgregarMusculo);
            EliminarMusculoCommand = new RelayCommand(EliminarMusculo);
            ActualizarMusculoCommand = new RelayCommand(ActualizarMusculo);

        }

        public void AgregarMusculo()
        {

        }

        public void EliminarMusculo() 
        { 

        }

        public void ActualizarMusculo()
        {

        } 

        */

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
