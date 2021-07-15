using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Applikacija.Leo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(entUsername.Text == "admin" && entPassword.Text == "admin")
            {
                Navigation.PushAsync(new NextPage(entUsername.Text));
            }
            else
            {
                DisplayAlert("Грешка", "Невалидно. Обидете се повторно!", "Продолжи");
            }
        }
    }
}
