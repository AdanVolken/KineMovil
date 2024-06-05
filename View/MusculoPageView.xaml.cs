using System;
using KineMovil.ViewModel;
using Microsoft.Maui.Controls;

namespace KineMovil.View
{
    public partial class MusculoPageView : ContentPage
    {
        private readonly List<Musculo> _musculos;

        public MusculoPageView(List<Musculo> musculos)
        {
            InitializeComponent();
            _musculos = musculos;
            BindingContext = this;
        }

        public List<Musculo> Musculos => _musculos;
    }
}
