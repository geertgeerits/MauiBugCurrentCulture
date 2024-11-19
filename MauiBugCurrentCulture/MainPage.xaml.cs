using System.Diagnostics;
using System.Globalization;

namespace MauiBugCurrentCulture
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            lblCurrentCulture.Text = "CurrentCulture:  " + CultureInfo.CurrentCulture.Name;

            Debug.WriteLine($"CultureInfo.CurrentCulture.Name: {CultureInfo.CurrentCulture.Name}");
        }
    }
}
