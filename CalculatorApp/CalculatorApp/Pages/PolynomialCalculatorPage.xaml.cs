using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolynomialCalculatorPage : ContentPage
    {
        public PolynomialCalculatorPage() { InitializeComponent(); }

        public void Solve(object sender, EventArgs e) 
        {
            string table, simplified, range;
            range = PolynomialCalculator.Solve(input.Text, out simplified, out table);
            this.table.Text = " " + table;
            this.simplified.Text = simplified;
            this.range.Text = range.Replace("=", "∈");
        }
    }
}