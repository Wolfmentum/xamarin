using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App5
{
    public partial class AddProduct : ContentPage
    {
        public AddProduct()
        {
            InitializeComponent();
            Button button = new Button
            {
                Text = "Add Product",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
           // button.Clicked += OnButtonClicked;
            this.Content = new StackLayout
            {
                Children =
                {
                   stack,
                   button
                }
            };
        }
       /* async void OnButtonClicked(object sender, EventArgs e)
        {
            string name = Nome.Text;
            string categor = Categoria.Text;
            string taga = Tag.Text;
            float pr = float.Parse(Preco.Text);
            await Navigation.PushAsync(new MainPage(name, categor, taga, pr));
        }*/

    }
}
