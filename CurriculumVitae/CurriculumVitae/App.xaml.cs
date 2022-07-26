﻿using CurriculumVitae.Services;
using CurriculumVitae.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurriculumVitae
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //  DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new PersonalInformationPage();
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
