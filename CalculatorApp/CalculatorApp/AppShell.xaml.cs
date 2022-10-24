using System;
using System.Collections.Generic;
using CalculatorApp.Pages;
using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BasicCalculatorPage), typeof(BasicCalculatorPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//BasicCalculatorPage");
        }
    }
}
