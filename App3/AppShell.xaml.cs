using App3.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App3
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Page1", typeof(Page1));
            Routing.RegisterRoute("Page2", typeof(Page2));
            Routing.RegisterRoute("Page3", typeof(Page2));
            Routing.RegisterRoute("Page4", typeof(Page4));
        }

    }
}
