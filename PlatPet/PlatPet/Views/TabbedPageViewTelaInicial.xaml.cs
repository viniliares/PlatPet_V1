using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlatPet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageViewTelaInicial : TabbedPage
    {
        public TabbedPageViewTelaInicial ()
        {
            InitializeComponent();

        }
        async void Banho(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentPageViewAgendarConsulta());
        }

        async void Consulta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentPageViewAgendarConsulta());
        }

        async void Adestramento(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentPageViewAgendarConsulta());
        }

        async void Servico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentPageCadastroUsuarioView());
        }
    }
}