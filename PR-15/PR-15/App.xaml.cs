﻿using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

namespace PR_15
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
