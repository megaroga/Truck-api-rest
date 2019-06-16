using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace truck
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
		public Cadastro ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Cadastro efetuado com sucesso!.", "OK");
            origem_cad.Text = "";
            destino_cad.Text = "";
            data_cad.Date = DateTime.Now;
            //hora_cad.Time = TimeZone;
            if (qtd_sala_cad.SelectedIndex != -1){qtd_sala_cad.SelectedIndex = -1;}
            qtd_sala_cad.ItemsSource.Clear();
            if (qtd_cozinha_cad.SelectedIndex != -1) { qtd_cozinha_cad.SelectedIndex = -1; }
            qtd_cozinha_cad.ItemsSource.Clear();
            if (qtd_dormitorio_cad.SelectedIndex != -1) { qtd_dormitorio_cad.SelectedIndex = -1; }
            qtd_dormitorio_cad.ItemsSource.Clear();
            if (qtd_lavanderia.SelectedIndex != -1) { qtd_lavanderia.SelectedIndex = -1; }
            qtd_lavanderia.ItemsSource.Clear();
            if (qtd_outros_cad.SelectedIndex != -1) { qtd_outros_cad.SelectedIndex = -1; }
            qtd_outros_cad.ItemsSource.Clear();
        }

    }
}