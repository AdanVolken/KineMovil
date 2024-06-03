using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KineMovil.ViewModel
{
    internal class VMParteCuerpo : INotifyPropertyChanged
    {

        private string _nombreParte;

        public string NombreParte
        {
            get { return _nombreParte; }
            set { _nombreParte = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
