using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DI
{
    public partial class MountainAreasView : ContentPage
    {
        public MountainAreasView(MountainAreasViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}

