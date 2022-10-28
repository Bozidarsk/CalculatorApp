using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Utils.Calculators;

namespace CalculatorApp.Pages
{
    public partial class BasicCalculatorPage : ContentPage
    {
        public BasicCalculatorPage() { InitializeComponent(); }

        private string input = "0";
        private bool use2nd = false;

        private void UpdateDisplay(string content) { display.Text = content; }
        public void OnButtonPress(object sender, EventArgs e) 
        {
            string arg = ((Button)sender).ClassId;
            switch (arg) 
            {
                case "=":
                    input = BasicCalculator.Solve(input);
                    if (input.StartsWith(BasicCalculator.ErrMsg)) { input = BasicCalculator.ErrMsg; }
                    break;
                case "cls":
                    input = "0";
                    break;
                case "bs":
                    if (input.Length <= 1) { input = "0"; break; }
                    input = input.Remove(input.Length - 1, 1);
                    if (input == "-") { input = "0"; }
                    break;
                case "2nd":
                    use2nd = !use2nd;
                    SwitchButtons("BasicCalculatorPage.xaml");
                    break;
                default:
                    if (input == "0") { input = ""; }
                    input += arg;
                    break;
            }

            UpdateDisplay(input);
        }

        public void SwitchButtons(string uri) 
        {
            pi.Text = (use2nd) ? "e" : "π";
            pi.ClassId = (use2nd) ? "e" : "pi";

            log.Text = (use2nd) ? "10^x" : "log";
            log.ClassId = (use2nd) ? "10^(" : "log(";

            sin.Text = (use2nd) ? "asin" : "sin";
            sin.ClassId = (use2nd) ? "asin(" : "sin(";

            cos.Text = (use2nd) ? "acos" : "cos";
            cos.ClassId = (use2nd) ? "acos(" : "cos(";

            tan.Text = (use2nd) ? "atan" : "tan";
            tan.ClassId = (use2nd) ? "atan(" : "tan(";

            carret.Text = (use2nd) ? "!" : "^";
            carret.ClassId = (use2nd) ? "!" : "^";

            sqrt.Text = (use2nd) ? "1/x" : "√";
            sqrt.ClassId = (use2nd) ? "^(-1)" : "√";
        }
    }
}