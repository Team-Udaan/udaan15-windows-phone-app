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
    public partial class EventDetails : PhoneApplicationPage
    {
        public EventDetails()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string name = null;
            if (NavigationContext.QueryString.TryGetValue("item", out name))
            {
                bool f = true;
                this.TitleString.Text = name;
                foreach (var item in App.VM.Ntevents.NTList)
                {
                    //f = true;
                    if(item.name == name)
                    {
                        f = false;
                        this.Dept.Text = "Department : " + item.Dept;
                        this.desc.Text = "Description : \r\n" + item.desc;
                        this.ptc.Text = "Number of Participants : "+item.NoOfParticipants;
                        //this.fees.Text = "Fees : " + item.Fee;
                        //this.prz.Text = "Prize : " + item.prize;
                        if (item.Managers != null)
                        {
                            this.mgrText.Text = "Managers : \r\n";
                        }
                        this.mgrs.ItemsSource = item.Managers;
                        
                        //break;
                    }
                }
                if(f)
                {
                    foreach (var item in App.VM.Devents.DEList)
                    {
                        if (item.name == name)
                        {
                            f = false;
                            this.Dept.Text = "Department : " + item.Dept;
                            this.desc.Text = "Description : \r\n" + item.desc;
                            this.ptc.Text = "Number of Participants : " + item.NoOfParticipants;
                            //this.fees.Text = "Fees : " + item.Fee;
                           // this.prz.Text = "Prize : " + item.prize;
                            if (item.Managers != null)
                            {
                                this.mgrText.Text = "Managers : \r\n";
                            }
                            this.mgrs.ItemsSource = item.Managers;
                        }
                    }
                }
            }
        }
    }
}