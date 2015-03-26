using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Udaan15
{
    public partial class TechNonTech : PhoneApplicationPage
    {
        public TechNonTech()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListPage.xaml?Title=Departments&path=/api/tech",UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListPage.xaml?Title=NonTech Events&path=/api/nontech/all", UriKind.Relative));
        }
    }
}