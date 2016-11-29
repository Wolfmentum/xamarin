using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App5
{
    public partial class Details : ContentPage
    {
        public Details(object detail)
        {
            InitializeComponent();

            Name.Text = (detail as Product).Name;
            Category.Text = (detail as Product).Category;
            Tag.Text = (detail as Product).Tag;
            Preço.Text = (detail as Product).Price+"";
            this.Content = new StackLayout
            {
                Children =
                {
                   stack
                }
            };
        }
    }
}
