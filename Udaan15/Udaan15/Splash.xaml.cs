using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
//using ImageTools.IO.Gif;
using Udaan_15.ViewModels;

namespace Udaan15
{
    public partial class Splash : PhoneApplicationPage
    {
        //public Uri ImageSource { get; set; }
       public Splash()
        {
            //ImageSource = new Uri("/assets/310.gif", UriKind.Relative);
            InitializeComponent();
            //ImageTools.IO.Decoders.AddDecoder<GifDecoder>();
            Loaded += SplashPage_Loaded;
        }

        void SplashPage_Loaded(object sender, RoutedEventArgs e)
        {
            //ADD YOUR CODE
            
            if(NetworkInterface.GetIsNetworkAvailable())
            {
                //App.VM.LoadDept();
                //App.VM.LoadNT();
                //App.VM.LoadCultural();
               // MessageBox.Show("Network available...");
                //App.VM.LoadCultural();
                DoIt();
            }
            else
            {
                MessageBox.Show("Network is not available. Please make sure phone is connected with internet..");
                Application.Current.Terminate();
            }

        }
        public async void DoIt()
        {
            List<Task> ls = new List<Task>();
            ls.Add(App.VM.MakeRequest("/api/tech/departments"));
            ls.Add(App.VM.MakeRequest("/api/tech/all"));
            ls.Add(App.VM.MakeRequest("/api/nontech/all"));
            await Task.WhenAll(ls);
            //MessageBox.Show("All Loaded");
            NavigationService.Navigate(new Uri("/mainpage.xaml",UriKind.Relative));
            NavigationService.RemoveBackEntry();
        }
    }
}