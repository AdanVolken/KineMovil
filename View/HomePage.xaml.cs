using System;
using Microsoft.Maui.Controls;
using Microsoft.Data.SqlClient;
using System.Linq;
using KineMovil.ViewModel;
using Dapper;
using KineMovil.ViewModel;

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
            using (var conexion = new SqlConnection(_connectionString))
            {
                await conexion.OpenAsync();
                var musculos = await conexion.QueryAsync<Musculo>("SELECT * FROM Musculos");
                var vm = new VMMusculo();
                vm.Musculos = musculos.ToList(); // Asigna los músculos a una propiedad en el ViewModel
                var musculoPageView = new MusculoPageView(vm);
                MainContentView.Content = musculoPageView.Content;
            }
        }

        private void btnSintomas_Clicked(object sender, EventArgs e)
        {
            var sintomasPageView = new SintomaPageView();
            MainContentView.Content = sintomasPageView.Content;
        }
    }
}