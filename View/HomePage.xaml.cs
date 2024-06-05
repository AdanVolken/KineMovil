using System;
using Microsoft.Maui.Controls;

namespace KineMovil.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

        }

        private void btnMusculo_Clicked(object sender, EventArgs e)
        {
            var musculoPageView = new MusculoPageView();
            MainContentView.Content = musculoPageView.Content;
        }

        private void btnSintomas_Clicked(object sender, EventArgs e)
        {
            var sintomasPageView = new SintomaPageView();
            MainContentView.Content = sintomasPageView.Content;
        }
    }
}