﻿using KineMovil.View;
namespace KineMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }
    }
}
