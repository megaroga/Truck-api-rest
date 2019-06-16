using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection.Emit;

namespace truck
{
    public class Carregando : ContentPage
    {
        Image CarregandoImage;

        public Carregando()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            CarregandoImage = new Image
            {
                Source = "logo.png",
                WidthRequest = 130,
                HeightRequest= 130
            };
            AbsoluteLayout.SetLayoutFlags(CarregandoImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(CarregandoImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(CarregandoImage);
            this.BackgroundColor = Color.FromHex("#071370");
            this.Content = sub;

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await CarregandoImage.ScaleTo(1, 2000);
            await CarregandoImage.ScaleTo(0.5, 1500, Easing.Linear);
            await CarregandoImage.ScaleTo(0.9, 600, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
