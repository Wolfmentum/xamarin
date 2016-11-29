using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        List<Product> products;
        public MainPage(object prod)
        {
            InitializeComponent();
            
            Label header = new Label
            {
                Text = "Products",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                Text = "Add Product",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;

            //Product p = new Product(name, category, tag, price);

            products = (prod as List<Product>);
            /*if(!name.Equals("vazio")&& !category.Equals("vazio") && !tag.Equals("vazio") && price != 0F)
            {
                products.Add(p);
            }*/


            MainListView.ItemsSource = products;
            

            // Build the page.
           this.Content = new StackLayout
            {
                Children =
                {
                   search,
                   header,
                    MainListView
                }
            };
        
    }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProduct());
        }
        public async void OnMore(object sender, SelectedItemChangedEventArgs e)
        {
            //var mi = ((MenuItem)sender);
            //DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
            await Navigation.PushAsync(new Details(e.SelectedItem));
        }

         public void OnSearch(object sender, EventArgs e)
        {
            string keyword = search.Text;

            IEnumerable<Product> searchResult = products.Where(el => el.Name.ToLower().Contains(keyword.ToLower()));

            MainListView.ItemsSource = searchResult;
           
        }
    }
}
