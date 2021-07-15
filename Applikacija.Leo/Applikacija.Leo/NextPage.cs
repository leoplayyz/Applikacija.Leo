using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Applikacija.Leo
{
    public class NextPage : ContentPage
    {
        public NextPage(string user)
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Успешна најава, " + user, 
                        FontSize = Device.GetNamedSize(NamedSize.Header, typeof(Label)), 
                        FontAttributes = FontAttributes.Bold, 
                        HorizontalTextAlignment = TextAlignment.Center }
                }
            };
        }
    }
}