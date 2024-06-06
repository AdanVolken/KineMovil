using System;
using Microsoft.Maui.Controls;
using Microsoft.Data.SqlClient;
using System.Linq;
using KineMovil.ViewModel;
using Dapper;
using KineMovil.ViewModel;
using KineMovil.Model;
using System.Collections.ObjectModel;

namespace KineMovil.View
{
    public partial class HomePage : ContentPage
    {
        private string _connectionString = "Server=DESKTOP-MIJH44D\\SQLSADAN;Database=KineApp;Trusted_Connection=True;";

        public HomePage()
        {
            InitializeComponent();

           
        }

        private async void btnMusculo_Clicked(object sender, EventArgs e)
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