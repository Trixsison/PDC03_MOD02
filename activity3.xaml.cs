﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC3_MOD2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity3 : ContentPage
    {
        public activity3()
        {
            InitializeComponent();
        }
        private async void BackPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}