using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using truck.Model;

namespace truck
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
		public Cadastro (int cod)
		{
			InitializeComponent ();
            Dados dadosus = pegarDados.VerUsuario(cod);
            nomeus.Text = dadosus.nome;
            usuarious.Text = dadosus.usuario;
            cpfus.Text = dadosus.cpf;
            foneus.Text = dadosus.telefone;

        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Cadastro efetuado com sucesso!.", "OK");
            
        }

    }
}