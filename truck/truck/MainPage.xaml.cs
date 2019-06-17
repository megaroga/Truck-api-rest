using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using truck.Model;

namespace truck
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Acessar_Clicked(object sender, EventArgs e)

        {


            Login end = verificarLogin.VerificarAutorizacao(nome.Text, senha.Text);
            int vard = Convert.ToInt32(end.Autorizar);
            if (vard == 1)
            {
                await DisplayAlert("Alert", "Login efetuado com sucesso!.", "OK");
                await Navigation.PushAsync(new Cadastro());
            }
            else
            {
                await DisplayAlert("Alert", "Usuario e senha não conferem, tente novamente!.", "OK");
                nome.Text = "";
                senha.Text = "";
            }

        }
    }
}
