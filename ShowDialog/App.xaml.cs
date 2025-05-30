﻿using System.Windows;
using Prism.Ioc;
using PrismWPF.Views;
using PrismWPF.ViewModels;

namespace PrismWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<SettingWindow, SettingWindowViewModel>();
        }
    }
}
