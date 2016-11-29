using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;

namespace App5.Windows
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new App5.App());
        }
        public async void OnMore(object sender, SelectedItemChangedEventArgs e)
        {
            //var mi = ((MenuItem)sender);
            //DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
            await Navigation.PushAsync(new Details(e.SelectedItem));
        }
    }
}
