﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sandals.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderItemTemplate : ContentView
    {
        public OrderItemTemplate()
        {
            InitializeComponent();
        }
    }
}