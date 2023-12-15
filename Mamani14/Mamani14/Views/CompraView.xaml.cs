﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mamani14.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mamani14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompraView : ContentPage
    {
        public CompraView()
        {
            InitializeComponent();
            this.BindingContext = new CompraViewModel();
        }
    }
}