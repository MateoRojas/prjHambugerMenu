﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace prjHambugerMenu
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(Portada));
            PortadaRadio.IsChecked = true;
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (Menu.IsPaneOpen)
            {
                Menu.IsPaneOpen = false;
            }
            else
            {
                Menu.IsPaneOpen = true;
            }

            btnMenu.IsChecked = false;
        }

        private void PortadaRadio_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Portada));
            PortadaRadio.IsChecked = true;
        }

        private void Page1Radio_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Pagina1));
            Page1Radio.IsChecked = true;
        }

        private void Page2Radio_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Pagina2));
            Page2Radio.IsChecked = true;
        }

        private void BackRadio_Click(object sender, RoutedEventArgs e)
        {
            if(ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }

            BackRadio.IsChecked = false;
        }
    }
}
