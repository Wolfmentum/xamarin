using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App5
{
    public partial class Category : ContentPage
    {
        List<Product> products;
        public Category()
        {
            InitializeComponent();
            Label header = new Label
            {
                Text = "Categories",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            products = new List<Product>
            {
               new Product("André Louro", "Categoria","Tagarino", 20.0F),
               new Product("Christian Lopes", "Ginásio","Tagarino", 20.0F),
               new Product("Tiago Mendes", "Casa","Tagarino", 20.0F)
            };

            MainListView.ItemsSource = products;

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
        public async void OnMore(object sender, SelectedItemChangedEventArgs e)
        {
            Product p = e.SelectedItem as Product;
            string cat = p.Category;
            IEnumerable<Product> searchResult = products.Where(el => el.Category.ToLower().Contains(cat.ToLower()));
            
            await Navigation.PushAsync(new MainPage(searchResult.ToList()));
        }
        public void OnSearch(object sender, EventArgs e)
        {
            string keyword = search.Text;

            IEnumerable<Product> searchResult2 = products.Where(el => el.Category.ToLower().Contains(keyword.ToLower()));

            MainListView.ItemsSource = searchResult2;

        }
    }
}
