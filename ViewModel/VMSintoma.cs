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
    class VMSintoma  : INotifyPropertyChanged
    {
        private string _nombre;
        private int _idParte;
        private string _descri;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged(); }
        }

        public int IdParte
        {
            get { return _idParte; }
            set { _idParte = value; OnPropertyChanged(); }
        }

        public string Descri
        {
            get { return _descri; }
            set { _descri = value; OnPropertyChanged(); }
        }

        


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
