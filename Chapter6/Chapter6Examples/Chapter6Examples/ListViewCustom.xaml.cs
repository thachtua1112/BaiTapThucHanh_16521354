﻿using Chapter6Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter6Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCustom : ContentPage
    {
        public ListViewCustom()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
             {
             new ListItem {Title = "First", Description="1st item", Price="$100.00"},
             new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
             new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
             };
            CustomList.ItemsSource = ListItems;
        }
        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}