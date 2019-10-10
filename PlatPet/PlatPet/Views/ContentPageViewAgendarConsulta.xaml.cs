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
	public partial class ContentPageViewAgendarConsulta : ContentPage
	{
		public ContentPageViewAgendarConsulta ()
		{
			InitializeComponent ();

            var monkeyList = new List<string>();
            monkeyList.Add("Alfredo");
            monkeyList.Add("Valentina");
            monkeyList.Add("Pistolinha");
            monkeyList.Add("Maria do Rosario");
            ;

            var icker = new Picker { Title = "Selecione seu Pet" };
            icker.ItemsSource = monkeyList;

           // var monkeyNameLabel = new Label();
            //monkeyNameLabel.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker));

           /* void OnPickerSelectedIndexChanged(object sender, EventArgs e)
            {
                var picker = (Picker)sender;
                int selectedIndex = picker.SelectedIndex;

               // if (selectedIndex != -1)
                //{
                  //  monkeyNameLabel.Text = (string)picker.ItemsSource[selectedIndex];
                //}
            }*/


            var list = new List<string>();
            list.Add("30,00 Banho");
            list.Add("35,00 Banho Tosa");
            
            

            var pppicker = new Picker { Title = "Selecione seu Pet" };
            pppicker.ItemsSource = list;

            var ilist = new List<string>();
            ilist.Add("Dinheiro");
            ilist.Add("Cartão de Crédito");
            ilist.Add("Cartão de Débito");
            ilist.Add("PetCash");
           

            var ppicker = new Picker { Title = "Selecione seu Pet" };
            pppicker.ItemsSource = list;
        }
	}
}