﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tickart.UI.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminMenuTabbedPage : TabbedPage
    {
        public AdminMenuTabbedPage()
        {
            InitializeComponent();
        }
    }
}