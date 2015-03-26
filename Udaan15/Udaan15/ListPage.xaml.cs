using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Udaan15.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Udaan_15.ViewModels;

namespace Udaan15
{
    public partial class ListPage : PhoneApplicationPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string path = null;
            if (NavigationContext.QueryString.TryGetValue("path", out path))
            {
                if(path == "/api/tech")
                {
                    if (!App.VM.DeptLoaded)
                        App.VM.LoadDept();
                    this.LongListSelector.ItemsSource = App.VM.Departments.ListOfDepartments;
                } 
                if (path == "/api/nontech/all")
                {
                    if (!App.VM.NteventsLoaded)
                        App.VM.LoadNT();
                    this.LongListSelector.ItemsSource = App.VM.Ntevents.NTList;
                }
                if (path == "/api/cultural")
                {
                    if (!App.VM.CulturalLoaded)
                        App.VM.LoadCultural();
                    //this.LongListSelector.ItemsSource = App.VM.CulturalList.CulturalEvents;
                }
                if(path=="Devents")
                {
                    if (!(App.VM.listToDisplay == null))
                    {
                        this.LongListSelector.ItemsSource = App.VM.listToDisplay;
                    }
                }
            }
            string title = null;
            if (NavigationContext.QueryString.TryGetValue("Title", out title))
            {
                TitleString.Text = title;
            }
        }

        private void LLSChanges(object sender, SelectionChangedEventArgs e)
        {
            bool x = true;
            foreach (var item in App.VM.Departments.ListOfDepartments)
            {
                x = true;
                if (LongListSelector.SelectedItem.Equals(item))
                {
                    x = false;
                    List<Event> ls = new List<Event>();
                    foreach (var i in App.VM.Devents.DEList)
                    {
                        if (i.Dept == item.name)
                        {
                            ls.Add(i);
                        }
                    }
                    if (ls.Count == 0)
                    {
                        MessageBox.Show("No Event in this Department");
                    }
                    else
                    {
                        App.VM.listToDisplay = ls;
                        NavigationService.Navigate(new Uri("/ListPage.xaml?Title=" + item.name + "&path=Devents", UriKind.Relative));
                        //NavigationService.RemoveBackEntry();
                        //LongListSelector.SelectedItem = null;
                    }
                    break;
                }
            }
            if(x)
            {
                if(this.LongListSelector.ItemsSource.Equals(App.VM.Ntevents.NTList))
                {
                    //MessageBox.Show("nt events");
                    foreach (var item in App.VM.Ntevents.NTList)
                    {
                        if(item.Equals(LongListSelector.SelectedItem))
                        {
                            //navigate to details page
                            NavigationService.Navigate(new Uri("/EventDetails.xaml?item=" + item.name, UriKind.Relative));
                            //NavigationService.RemoveBackEntry();
                            //LongListSelector.SelectedItem = null;
                            //break;
                            //return;
                        }
                    }
                }
                else if(this.LongListSelector.ItemsSource.Equals(App.VM.listToDisplay))
                {
                    //MessageBox.Show("Tevents");
                    foreach (var item in App.VM.listToDisplay)
                    {
                        if (LongListSelector.SelectedItem.Equals(item))
                        {
                            //navigate to details page
                            NavigationService.Navigate(new Uri("/EventDetails.xaml?item=" + item.name, UriKind.Relative));
                            //NavigationService.RemoveBackEntry();
                            //LongListSelector.SelectedItem = null;
                            break;
                        }
                    }
                }
            }
            
        }
    }
}